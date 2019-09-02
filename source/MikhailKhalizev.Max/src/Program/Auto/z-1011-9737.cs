using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9737-8191cfb5")]
        public void Method_1011_9737()
        {
            ii(0x1011_9737, 5); push(0x30);                             /* push 0x30 */
            ii(0x1011_973c, 5); call(Definitions.sys_check_available_stack_size, 0x4_c611); /* call 0x10165d52 */
            ii(0x1011_9741, 1); push(esi);                              /* push esi */
            ii(0x1011_9742, 1); push(edi);                              /* push edi */
            ii(0x1011_9743, 1); push(ebp);                              /* push ebp */
            ii(0x1011_9744, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9746, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_974c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_974f, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1011_9752, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1011_9755, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1011_9758, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1011_975c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_975e, 2); if(jz(0x1011_9769, 9)) goto l_0x1011_9769; /* jz 0x10119769 */
            ii(0x1011_9760, 7); cmp(memb[ds, 0x101c_37cc], 0);          /* cmp byte [0x101c37cc], 0x0 */
            ii(0x1011_9767, 2); if(jnz(0x1011_976e, 5)) goto l_0x1011_976e; /* jnz 0x1011976e */
        l_0x1011_9769:
            ii(0x1011_9769, 5); jmp(0x1011_98a1, 0x133); goto l_0x1011_98a1; /* jmp 0x101198a1 */
        l_0x1011_976e:
            ii(0x1011_976e, 5); mov(eax, 0x40_0000);                    /* mov eax, 0x400000 */
            ii(0x1011_9773, 5); mov(edx, 0x40_0000);                    /* mov edx, 0x400000 */
            ii(0x1011_9778, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_977b, 6); idiv(memd[ds, 0x101c_38c4]);            /* idiv dword [0x101c38c4] */
            ii(0x1011_9781, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1011_9784, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1011_9787, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1011_978b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_978d, 6); if(jl(0x1011_98a1, 0x10e)) goto l_0x1011_98a1; /* jl 0x101198a1 */
            ii(0x1011_9793, 5); mov(eax, 0x293);                        /* mov eax, 0x293 */
            ii(0x1011_9798, 5); call(Definitions.my_get_res_data_by_id, 0x1_a83b); /* call 0x10133fd8 */
            ii(0x1011_979d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_97a0, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_97a3, 4); mov(ax, memw[ds, eax + 2]);             /* mov ax, [eax+0x2] */
            ii(0x1011_97a7, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1011_97ab, 6); if(jg(0x1011_98a1, 0xf0)) goto l_0x1011_98a1; /* jg 0x101198a1 */
            ii(0x1011_97b1, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_97b4, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1011_97b7, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_97bb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_97bd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_97c0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_97c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_97c4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1011_97c8, 5); call(Definitions.my_min, -0x9_0049);    /* call 0x10089784 */
            ii(0x1011_97cd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_97d0, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1011_97d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_97d6, 6); if(jz(0x1011_98a1, 0xc5)) goto l_0x1011_98a1; /* jz 0x101198a1 */
            ii(0x1011_97dc, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1011_97df, 2); mov(ebx, memd[ds, edx]);                /* mov ebx, [edx] */
            ii(0x1011_97e1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1011_97e4, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_97e8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_97ea, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_97ed, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_97ef, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1011_97f1, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1011_97f3, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_97f7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_97f9, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_97fc, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1011_9800, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9802, 6); if(jl(0x1011_98a1, 0x99)) goto l_0x1011_98a1; /* jl 0x101198a1 */
            ii(0x1011_9808, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_980b, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1011_980e, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_9812, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_9814, 5); mov(eax, memd[ds, 0x101b_8748]);        /* mov eax, [0x101b8748] */
            ii(0x1011_9819, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_981c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_981e, 6); if(jge(0x1011_98a1, 0x7d)) goto l_0x1011_98a1; /* jge 0x101198a1 */
            ii(0x1011_9824, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x1011_9827, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x1011_982a, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1011_982e, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1011_9831, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_9833, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1011_9837, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_9839, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_983c, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1011_983e, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1011_9840, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1011_9842, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_9846, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_9848, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1011_984b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_984e, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1011_9851:
            ii(0x1011_9851, 3); dec(memd[ss, ebp - 0x1c]);              /* dec dword [ebp-0x1c] */
            ii(0x1011_9854, 5); cmp(memw[ss, ebp - 0x1c], -1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x1011_9859, 2); if(jz(0x1011_98a1, 0x46)) goto l_0x1011_98a1; /* jz 0x101198a1 */
            ii(0x1011_985b, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x1011_985f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_9861, 2); if(jl(0x1011_987b, 0x18)) goto l_0x1011_987b; /* jl 0x1011987b */
            ii(0x1011_9863, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_9866, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1011_9869, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_986d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_986f, 5); mov(eax, memd[ds, 0x101b_8746]);        /* mov eax, [0x101b8746] */
            ii(0x1011_9874, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_9877, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_9879, 2); if(jl(0x1011_987d, 2)) goto l_0x1011_987d; /* jl 0x1011987d */
        l_0x1011_987b:
            ii(0x1011_987b, 2); jmp(0x1011_9896, 0x19); goto l_0x1011_9896; /* jmp 0x10119896 */
        l_0x1011_987d:
            ii(0x1011_987d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_9880, 1); push(eax);                              /* push eax */
            ii(0x1011_9881, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1011_9886, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_988a, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1011_988e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_9891, 5); call(0x100e_8d1e, -0x3_0b78);           /* call 0x100e8d1e */
        l_0x1011_9896:
            ii(0x1011_9896, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_9899, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1011_989c, 3); add(memd[ss, ebp - 0xc], eax);          /* add [ebp-0xc], eax */
            ii(0x1011_989f, 2); jmp(0x1011_9851, -0x50); goto l_0x1011_9851; /* jmp 0x10119851 */
        l_0x1011_98a1:
            ii(0x1011_98a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_98a3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_98a4, 1); pop(edi);                               /* pop edi */
            ii(0x1011_98a5, 1); pop(esi);                               /* pop esi */
            ii(0x1011_98a6, 1); ret();                                  /* ret */
        }
    }
}
