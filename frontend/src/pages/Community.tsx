import { CommBuild } from "../components/CommunityPage/CommBuild"
import { CommStick } from "../components/CommunityPage/CommStick"

export default function Community(){
    return(
        <>
        
        <div className=" absolute px-6 py-6 grid w-full max-w-full h-9/10 gap-6 grid-rows-2 ">
            <div className=" relative bg-black/10 border-4 gap-4 rounded-lg overflow-x-auto grid grid-flow-col auto-cols-[calc(33.33%-12px)] border-black/10">
                <CommBuild/> 
                <CommBuild/> 
                <CommBuild/> 
                <CommBuild/> 
                <CommBuild/> 
                <CommBuild/> 
                <CommBuild/>                 
            </div>
            <div className=" relative bg-black/10 border-4 gap-4 rounded-lg overflow-x-auto grid grid-flow-col auto-cols-[calc(33.33%-12px)] border-black/10">
                <CommStick/>
                <CommStick/>
                <CommStick/>
                <CommStick/>
                <CommStick/>
            </div>

        </div>
        </>
    )
}