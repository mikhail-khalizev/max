using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("459c4cf9-7834-49a6-b9de-584f4eb61363")]
        public void Method_1013_f629()
        {
            ii(0x1013_f629, 5); pushd(0x68);                            /* push 0x68 */
            ii(0x1013_f62e, 5); calld(Definitions.sys_check_available_stack_size, 0x2671f); /* call 0x10165d52 */
            ii(0x1013_f633, 1); pushd(esi);                             /* push esi */
            ii(0x1013_f634, 1); pushd(edi);                             /* push edi */
            ii(0x1013_f635, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_f636, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_f638, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1013_f63e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_f641, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_f644, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_f647, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1013_f64a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1013_f64e, 5); calld(Definitions.my_get_res_data_by_id, -0xb67b); /* call 0x10133fd8 */
            ii(0x1013_f653, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1013_f656, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1013_f65a, 5); calld(Definitions.my_get_res_data_by_id, -0xb687); /* call 0x10133fd8 */
            ii(0x1013_f65f, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1013_f662, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x1013_f666, 2); if(jnzd(0x1013_f674, 0xc)) goto l_0x1013_f674; /* jnz 0x1013f674 */
            ii(0x1013_f668, 7); mov(memd_a32[ss, ebp - 0x44], 0);       /* mov dword [ebp-0x44], 0x0 */
            ii(0x1013_f66f, 5); jmpd(0x1013_f899, 0x225); goto l_0x1013_f899; /* jmp 0x1013f899 */
        l_0x1013_f674:
            ii(0x1013_f674, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1013_f678, 2); if(jnzd(0x1013_f680, 0x6)) goto l_0x1013_f680; /* jnz 0x1013f680 */
            ii(0x1013_f67a, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f67d, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
        l_0x1013_f680:
            ii(0x1013_f680, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1013_f683, 3); sub(memd_a32[ss, ebp + 0x18], eax);     /* sub [ebp+0x18], eax */
            ii(0x1013_f686, 5); cmp(memw_a32[ss, ebp + 0x18], 0);       /* cmp word [ebp+0x18], 0x0 */
            ii(0x1013_f68b, 2); if(jzd(0x1013_f691, 0x4)) goto l_0x1013_f691; /* jz 0x1013f691 */
            ii(0x1013_f68d, 4); add(memd_a32[ss, ebp - 0x4], -0x5 /* 0xfb */); /* add dword [ebp-0x4], 0xfffffffb */
        l_0x1013_f691:
            ii(0x1013_f691, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1013_f695, 3); cmp(eax, 0x6);                          /* cmp eax, 0x6 */
            ii(0x1013_f698, 2); if(jged(0x1013_f6a3, 0x9)) goto l_0x1013_f6a3; /* jge 0x1013f6a3 */
            ii(0x1013_f69a, 7); mov(memd_a32[ss, ebp - 0x38], 0);       /* mov dword [ebp-0x38], 0x0 */
            ii(0x1013_f6a1, 2); jmpd(0x1013_f6c4, 0x21); goto l_0x1013_f6c4; /* jmp 0x1013f6c4 */
        l_0x1013_f6a3:
            ii(0x1013_f6a3, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f6a6, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_f6a8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_f6ab, 5); mov(eax, 0x12);                         /* mov eax, 0x12 */
            ii(0x1013_f6b0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_f6b2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_f6b4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f6b6, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f6b9, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_f6bc, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1013_f6be, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1013_f6c1, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1013_f6c4:
            ii(0x1013_f6c4, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_f6c8, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_f6cb, 5); mov(ebx, 0x12);                         /* mov ebx, 0x12 */
            ii(0x1013_f6d0, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1013_f6d2, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f6d5, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_f6d7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1013_f6da, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1013_f6dc, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1013_f6de, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f6e0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f6e3, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_f6e5, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_f6e7, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f6eb, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1013_f6ee, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1013_f6f1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_f6f3, 3); mov(memd_a32[ss, ebp - 0x48], edx);     /* mov [ebp-0x48], edx */
            ii(0x1013_f6f6, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1013_f6fa, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1013_f6fd, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1013_f702, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f704, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f707, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_f709, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1013_f70c, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1013_f70f, 1); dec(eax);                               /* dec eax */
            ii(0x1013_f710, 3); imul(eax, eax, 0x5);                    /* imul eax, eax, 0x5 */
            ii(0x1013_f713, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1013_f716, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_f718, 3); mov(memd_a32[ss, ebp - 0x20], edx);     /* mov [ebp-0x20], edx */
            ii(0x1013_f71b, 4); movsx(edx, memw_a32[ss, ebp + 0x18]);   /* movsx edx, word [ebp+0x18] */
            ii(0x1013_f71f, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1013_f722, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1013_f727, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f729, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f72c, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_f72e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_f731, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_f734, 1); dec(eax);                               /* dec eax */
            ii(0x1013_f735, 3); imul(eax, eax, 0x5);                    /* imul eax, eax, 0x5 */
            ii(0x1013_f738, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x1013_f73b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_f73d, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1013_f740, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1013_f743, 3); add(eax, memd_a32[ss, ebp - 0x1c]);     /* add eax, [ebp-0x1c] */
            ii(0x1013_f746, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_f749, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1013_f74c, 3); mov(ax, memw_a32[ds, edx]);             /* mov ax, [edx] */
            ii(0x1013_f74f, 4); imul(eax, memd_a32[ss, ebp - 0x14]);    /* imul eax, [ebp-0x14] */
            ii(0x1013_f753, 3); sub(memd_a32[ss, ebp - 0x4], eax);      /* sub [ebp-0x4], eax */
            ii(0x1013_f756, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1013_f759, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_f75c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_f761, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x1013_f764, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_f766, 3); mov(memd_a32[ss, ebp - 0x2c], edx);     /* mov [ebp-0x2c], edx */
            ii(0x1013_f769, 5); cmp(memw_a32[ss, ebp - 0x1c], 0);       /* cmp word [ebp-0x1c], 0x0 */
            ii(0x1013_f76e, 2); if(jzd(0x1013_f77b, 0xb)) goto l_0x1013_f77b; /* jz 0x1013f77b */
            ii(0x1013_f770, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_f775, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x1013_f778, 3); sub(memd_a32[ss, ebp - 0x2c], eax);     /* sub [ebp-0x2c], eax */
        l_0x1013_f77b:
            ii(0x1013_f77b, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_f77f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_f781, 2); if(jnzd(0x1013_f798, 0x15)) goto l_0x1013_f798; /* jnz 0x1013f798 */
            ii(0x1013_f783, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f786, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1013_f789, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_f78c, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1013_f793, 5); jmpd(0x1013_f808, 0x70); goto l_0x1013_f808; /* jmp 0x1013f808 */
        l_0x1013_f798:
            ii(0x1013_f798, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_f79b, 4); cmp(ax, memw_a32[ss, ebp - 0x2c]);      /* cmp ax, [ebp-0x2c] */
            ii(0x1013_f79f, 2); if(jld(0x1013_f7d0, 0x2f)) goto l_0x1013_f7d0; /* jl 0x1013f7d0 */
            ii(0x1013_f7a1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f7a5, 4); movsx(ebx, memw_a32[ss, ebp - 0x2c]);   /* movsx ebx, word [ebp-0x2c] */
            ii(0x1013_f7a9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f7ab, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f7ae, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_f7b0, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1013_f7b3, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1013_f7b6, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1013_f7b9, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x1013_f7bc, 2); if(jled(0x1013_f7c7, 0x9)) goto l_0x1013_f7c7; /* jle 0x1013f7c7 */
            ii(0x1013_f7be, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f7c1, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1013_f7c4, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x1013_f7c7:
            ii(0x1013_f7c7, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1013_f7ce, 2); jmpd(0x1013_f808, 0x38); goto l_0x1013_f808; /* jmp 0x1013f808 */
        l_0x1013_f7d0:
            ii(0x1013_f7d0, 7); mov(memd_a32[ss, ebp - 0x34], 0x1);     /* mov dword [ebp-0x34], 0x1 */
            ii(0x1013_f7d7, 5); cmp(memw_a32[ss, ebp - 0x1c], 0);       /* cmp word [ebp-0x1c], 0x0 */
            ii(0x1013_f7dc, 2); if(jzd(0x1013_f7e4, 0x6)) goto l_0x1013_f7e4; /* jz 0x1013f7e4 */
            ii(0x1013_f7de, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_f7e1, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
        l_0x1013_f7e4:
            ii(0x1013_f7e4, 4); movsx(eax, memw_a32[ss, ebp - 0x2c]);   /* movsx eax, word [ebp-0x2c] */
            ii(0x1013_f7e8, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f7ec, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_f7ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_f7f0, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1013_f7f4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_f7f6, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x1013_f7fa, 1); dec(ebx);                               /* dec ebx */
            ii(0x1013_f7fb, 3); lea(edx, eax - 0x2);                    /* lea edx, [eax-0x2] */
            ii(0x1013_f7fe, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_f800, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_f803, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1013_f805, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1013_f808:
            ii(0x1013_f808, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x1013_f80b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1013_f80e, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1013_f811, 3); add(dx, memw_a32[ds, eax]);             /* add dx, [eax] */
            ii(0x1013_f814, 3); sub(edx, memd_a32[ss, ebp - 0x28]);     /* sub edx, [ebp-0x28] */
            ii(0x1013_f817, 3); mov(memd_a32[ss, ebp - 0x30], edx);     /* mov [ebp-0x30], edx */
            ii(0x1013_f81a, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_f81e, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f81f, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1013_f823, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f824, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x1013_f828, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f829, 4); movsx(ecx, memw_a32[ss, ebp + 0x14]);   /* movsx ecx, word [ebp+0x14] */
            ii(0x1013_f82d, 3); mov(ebx, memd_a32[ss, ebp - 0x3c]);     /* mov ebx, [ebp-0x3c] */
            ii(0x1013_f830, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f834, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1013_f837, 5); calld(0x1013_f56c, -0x2d0);             /* call 0x1013f56c */
            ii(0x1013_f83c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_f83f, 5); cmp(memw_a32[ss, ebp + 0x18], 0);       /* cmp word [ebp+0x18], 0x0 */
            ii(0x1013_f844, 2); if(jzd(0x1013_f893, 0x4d)) goto l_0x1013_f893; /* jz 0x1013f893 */
            ii(0x1013_f846, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1013_f848, 2); pushd(0x10);                            /* push 0x10 */
            ii(0x1013_f84a, 2); pushd(0);                               /* push 0x0 */
            ii(0x1013_f84c, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1013_f851, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_f853, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f857, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1013_f85b, 3); add(eax, memd_a32[ss, ebp - 0x10]);     /* add eax, [ebp-0x10] */
            ii(0x1013_f85e, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_f861, 5); calld(/* sys */ 0x1016_a5a0, 0x2ad3a);  /* call 0x1016a5a0 */
            ii(0x1013_f866, 4); add(memd_a32[ss, ebp - 0x24], 0x5);     /* add dword [ebp-0x24], 0x5 */
            ii(0x1013_f86a, 4); movsx(eax, memw_a32[ss, ebp - 0x38]);   /* movsx eax, word [ebp-0x38] */
            ii(0x1013_f86e, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f86f, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x1013_f873, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f874, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x1013_f878, 1); pushd(eax);                             /* push eax */
            ii(0x1013_f879, 4); movsx(ecx, memw_a32[ss, ebp + 0x18]);   /* movsx ecx, word [ebp+0x18] */
            ii(0x1013_f87d, 3); mov(ebx, memd_a32[ss, ebp - 0x40]);     /* mov ebx, [ebp-0x40] */
            ii(0x1013_f880, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_f884, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1013_f888, 3); add(eax, memd_a32[ss, ebp - 0x48]);     /* add eax, [ebp-0x48] */
            ii(0x1013_f88b, 5); calld(0x1013_f56c, -0x324);             /* call 0x1013f56c */
            ii(0x1013_f890, 3); add(memd_a32[ss, ebp - 0x24], eax);     /* add [ebp-0x24], eax */
        l_0x1013_f893:
            ii(0x1013_f893, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_f896, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x1013_f899:
            ii(0x1013_f899, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1013_f89c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_f89e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_f89f, 1); popd(edi);                              /* pop edi */
            ii(0x1013_f8a0, 1); popd(esi);                              /* pop esi */
            ii(0x1013_f8a1, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}