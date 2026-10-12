type ButtonTypes = {
    name: string
}

export default function Button(props: ButtonTypes)
{
    return (
        <>
            <button className='bg-olive-400 hover:bg-gray-400 text-white h-8 font-bold py-1 px-4 rounded-full'>{props.name}</button>
        </>
    )
}
