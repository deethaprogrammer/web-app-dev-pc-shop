import avatar from "../../assets/images/avatar.png"

export default function DropdownMenu(){

    return(
        <div className="relative inline-block">
            <button 
            className="rounded-full p-2 transition-colors hover:bg-olive-700 cursor-pointer" 
            >
                <img src= {avatar} alt="avatar" className="h-8"/>
            </button>
        </div>
    )
}

