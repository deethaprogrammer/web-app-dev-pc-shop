import { Link } from "react-router-dom";

type ButtonProps = {
    title: string,
    page: string,
}

export default function NavbarButton(props: ButtonProps){
    return(
        <>
            <Link to={props.page} className="button">
                {props.title}
            </Link>
        </>
    )
}