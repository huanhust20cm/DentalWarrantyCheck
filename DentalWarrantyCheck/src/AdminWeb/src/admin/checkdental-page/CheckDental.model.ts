export interface IPaginationProps {
  totalRecordCount: number | undefined;
  currentPage: number;
}

export const enum KnowledgeOption {
  Crowns = 0,
  Implant = 1,
  Brace = 2
}

export interface KnowledgePreviewRefInterface {
  onOpen: (data?: string) => void;
}

export interface PanelRefInterface {
  onOpen: (data?: A, isView?: boolean) => void;
}

export const knowledgeOption = [
  {
    label: 'Bọc răng sứ',
    value: KnowledgeOption.Crowns
  },
  {
    label: 'Implant',
    value: KnowledgeOption.Implant
  },
  {
    label: 'Niềng răng',
    value: KnowledgeOption.Brace
  }
];
export const genderKnowledgeOption = (options: number) => {
  switch (options) {
    case KnowledgeOption.Implant:
      return 'Implant';
    case KnowledgeOption.Brace:
      return 'Niềng răng';
    case KnowledgeOption.Crowns:
      return 'Bọc răng sứ';
    default:
      break;
  }
};
