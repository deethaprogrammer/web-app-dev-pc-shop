import { NavLink } from "react-router-dom";

type ButtonProps = {
  title: string;
  page: string;
};

export default function NavbarButton({ title, page }: ButtonProps) {
  return (
    <NavLink
      to={page}
      className={({ isActive }) =>
        `px-4 py-2 rounded-full text-sm font-medium transition-colors duration-200 ${
          isActive
            ? "bg-olive-800 text-white"
            : "text-olive-50 hover:bg-olive-700 hover:text-white"
        }`
      }
    >
      {title}
    </NavLink>
  );
}