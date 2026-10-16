import { useState } from "react";
import PreBuiltCategory from "../components/prebuilt/PreBuiltCategory";

import AllPreBuilts from '../components/prebuilt/pages/AllPreBuilts'
import GamingPreBuilts from "../components/prebuilt/pages/GamingPreBuilts";
import WorkstationPreBuilts from "../components/prebuilt/pages/WorkstationPreBuilts";
import OfficePreBuilts from "../components/prebuilt/pages/OfficePreBuilts";
import BudgetPreBuilts from "../components/prebuilt/pages/BudgetPreBuilts";

type pageType = 'all' | 'gaming' | 'workstation' | 'office' | 'budget';

export default function Prebuilts(){
    const [currentPage, setCurrentPage] = useState<pageType>("all");

    const renderPage = () => {
        switch (currentPage){
            case "all":
                return <AllPreBuilts />
            case "gaming":
                return <GamingPreBuilts />
            case "workstation":
                return <WorkstationPreBuilts />
            case "office":
                return <OfficePreBuilts />
            case "budget":
                return <BudgetPreBuilts />
            default:
                return <h1>Pick a page</h1>
        }
    }

    return(
        <>
            <div className="flex flex-col align-content">
                <div className="flex justify-center gap-5 mt-8 mb-8">
                    <button onClick={() => setCurrentPage('all')}>
                        <PreBuiltCategory title="All" />
                    </button>
                    <button onClick={() => setCurrentPage('gaming')}>
                        <PreBuiltCategory title="Gaming" />
                    </button>
                    <button onClick={() => setCurrentPage('workstation')}>
                        <PreBuiltCategory title="Workstation"/>
                    </button>
                    <button onClick={() => setCurrentPage('office')}>
                        <PreBuiltCategory title="Office" />
                    </button>
                    <button onClick={() => setCurrentPage('budget')}>
                        <PreBuiltCategory title="Budget" />
                    </button>
                </div>

                <div className="w-6xl h-120 outline-1 mx-auto rounded-lg">
                    {renderPage()}
                </div>
            </div>
        </>
    )
}
