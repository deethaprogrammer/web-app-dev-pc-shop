import avatar from "../../assets/images/avatar.png"
import { useState, useRef, useEffect } from "react";
import { NavLink } from "react-router-dom";

export default function DropdownMenu(){
    const [menuIsOpen, setmenuIsOpen] = useState(false);
    const dropdownRef = useRef<HTMLDivElement>(null);

    useEffect(() => {
        function handleClickOutside(event: MouseEvent) {
            if (dropdownRef.current && !dropdownRef.current.contains(event.target as Node)) {
                setmenuIsOpen(false)
            }
        }
        document.addEventListener("pointerdown", handleClickOutside)

        return () => document.removeEventListener("pointerdown", handleClickOutside);
    }, []);
    const close = () => setmenuIsOpen(false);

    return(
        <div ref={dropdownRef} className="relative inline-block">
            <button 
            className="rounded-full p-2 transition-colors hover:bg-olive-700 cursor-pointer" 
            onClick={() => setmenuIsOpen(!menuIsOpen) }
            >
                <img src= {avatar} alt="avatar" className="h-8"/>
            </button>

            {menuIsOpen && (
                <div className="absolute right-0 top-full z-50 w-34 rounded-2xl bg-olive-500 p-3 flex flex-col gap-1">
                    <MenuButton title="User profile" page="/UserProfile" onClick={close} />
                    <MenuButton title="My builds" page="/MyBuilds" onClick={close} />
                    <MenuButton title="Log in/out" page="/Login" onClick={close} />
                </div>
            )}
        </div>
    )
}

type MenuButtonProps = {title: string; page: string; onClick?: () => void};

function MenuButton({ title, page, onClick }: MenuButtonProps) {
    return (
        <NavLink
        to={page}
        onClick={onClick}
        className={({ isActive }) =>
            `px-4 py-2 rounded-full text-sm font-medium transition-colors duration-200 ${
            isActive
                ? "bg-olive-700 text-white"
                : "text-olive-50 hover:bg-olive-600 hover:text-white"
            }`
        }
        >
        {title}
        </NavLink>
  );
}