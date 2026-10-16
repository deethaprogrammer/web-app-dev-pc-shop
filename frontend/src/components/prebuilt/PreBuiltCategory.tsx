type categories = {
    title: string
}

export default function PreBuiltCategory({title}: categories){
    return(
        <>
            <div className="text-center w-30 h-30 outline-1 hover:w-60 rounded-lg transition-all">
                {title}
            </div>
        </>
    )
}