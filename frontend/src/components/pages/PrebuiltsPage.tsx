import PreBuiltCategory from "../prebuilt/PreBuiltCategory";

export default function PrebuiltsPage(){
    return(
        <>
            <div className="align-content justify-center">
                <div className="flex items-center justify-center gap-5 mt-8 mb-8">
                    <PreBuiltCategory />
                    <PreBuiltCategory />
                    <PreBuiltCategory />
                    <PreBuiltCategory />
                </div>

                <div className="w-180 h-80 outline-1">
                    
                </div>
            </div>
        </>
    )
}