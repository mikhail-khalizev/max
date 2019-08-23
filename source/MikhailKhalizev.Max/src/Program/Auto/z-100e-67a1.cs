using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_67a1-4cc20da4")]
        public void Method_100e_67a1()
        {
            ii(0x100e_67a1, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100e_67a6, 5); call(Definitions.sys_check_available_stack_size, 0x7_f5a7); /* call 0x10165d52 */
            ii(0x100e_67ab, 1); push(esi);                              /* push esi */
            ii(0x100e_67ac, 1); push(edi);                              /* push edi */
            ii(0x100e_67ad, 1); push(ebp);                              /* push ebp */
            ii(0x100e_67ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_67b0, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100e_67b6, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_67b9, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_67bc, 3); mov(memd[ss, ebp - 0x10], ebx);         /* mov [ebp-0x10], ebx */
            ii(0x100e_67bf, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_67c2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_67c4, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_67c8, 5); call(0x1007_6e7c, -0x6_f951);           /* call 0x10076e7c */
            ii(0x100e_67cd, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_67d0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_67d2, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_67d6, 5); call(0x1007_6e7c, -0x6_f95f);           /* call 0x10076e7c */
            ii(0x100e_67db, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_67de, 5); mov(eax, memd[ds, 0x101b_8746]);        /* mov eax, [0x101b8746] */
            ii(0x100e_67e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_67e6, 3); lea(edx, memd[ds, eax - 0x1]);          /* lea edx, [eax-0x1] */
            ii(0x100e_67e9, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_67ed, 5); call(Definitions.my_min, -0x5_d06e);    /* call 0x10089784 */
            ii(0x100e_67f2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_67f5, 6); mov(edx, memd[ds, 0x101b_8748]);        /* mov edx, [0x101b8748] */
            ii(0x100e_67fb, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_67fe, 1); dec(edx);                               /* dec edx */
            ii(0x100e_67ff, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_6803, 5); call(Definitions.my_min, -0x5_d084);    /* call 0x10089784 */
            ii(0x100e_6808, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_680b, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_680f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6811, 2); if(jl(0x100e_681f, 0xc)) goto l_0x100e_681f; /* jl 0x100e681f */
            ii(0x100e_6813, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_6816, 7); cmp(ax, memw[ds, 0x101b_874a]);         /* cmp ax, [0x101b874a] */
            ii(0x100e_681d, 2); if(jl(0x100e_6821, 0x2)) goto l_0x100e_6821; /* jl 0x100e6821 */
        l_0x100e_681f:
            ii(0x100e_681f, 2); jmp(0x100e_6845, 0x24); goto l_0x100e_6845; /* jmp 0x100e6845 */
        l_0x100e_6821:
            ii(0x100e_6821, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_6825, 1); push(eax);                              /* push eax */
            ii(0x100e_6826, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_682a, 1); push(eax);                              /* push eax */
            ii(0x100e_682b, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_682f, 1); push(eax);                              /* push eax */
            ii(0x100e_6830, 4); movsx(ecx, memw[ss, ebp - 0x8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x100e_6834, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100e_6838, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_683d, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_6840, 5); call(/* sys */ 0x1016_a5a0, 0x8_3d5b);  /* call 0x1016a5a0 */
        l_0x100e_6845:
            ii(0x100e_6845, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6849, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_684b, 2); if(jl(0x100e_6859, 0xc)) goto l_0x100e_6859; /* jl 0x100e6859 */
            ii(0x100e_684d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_6850, 7); cmp(ax, memw[ds, 0x101b_8748]);         /* cmp ax, [0x101b8748] */
            ii(0x100e_6857, 2); if(jl(0x100e_685b, 0x2)) goto l_0x100e_685b; /* jl 0x100e685b */
        l_0x100e_6859:
            ii(0x100e_6859, 2); jmp(0x100e_687f, 0x24); goto l_0x100e_687f; /* jmp 0x100e687f */
        l_0x100e_685b:
            ii(0x100e_685b, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_685f, 1); push(eax);                              /* push eax */
            ii(0x100e_6860, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_6864, 1); push(eax);                              /* push eax */
            ii(0x100e_6865, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x100e_6869, 1); push(eax);                              /* push eax */
            ii(0x100e_686a, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x100e_686e, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x100e_6872, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_6877, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_687a, 5); call(/* sys */ 0x1016_a5a0, 0x8_3d21);  /* call 0x1016a5a0 */
        l_0x100e_687f:
            ii(0x100e_687f, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_6883, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_6885, 2); if(jl(0x100e_6893, 0xc)) goto l_0x100e_6893; /* jl 0x100e6893 */
            ii(0x100e_6887, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_688a, 7); cmp(ax, memw[ds, 0x101b_874a]);         /* cmp ax, [0x101b874a] */
            ii(0x100e_6891, 2); if(jl(0x100e_6895, 0x2)) goto l_0x100e_6895; /* jl 0x100e6895 */
        l_0x100e_6893:
            ii(0x100e_6893, 2); jmp(0x100e_68b9, 0x24); goto l_0x100e_68b9; /* jmp 0x100e68b9 */
        l_0x100e_6895:
            ii(0x100e_6895, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_6899, 1); push(eax);                              /* push eax */
            ii(0x100e_689a, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_689e, 1); push(eax);                              /* push eax */
            ii(0x100e_689f, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_68a3, 1); push(eax);                              /* push eax */
            ii(0x100e_68a4, 4); movsx(ecx, memw[ss, ebp - 0x4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_68a8, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100e_68ac, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_68b1, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_68b4, 5); call(/* sys */ 0x1016_a5a0, 0x8_3ce7);  /* call 0x1016a5a0 */
        l_0x100e_68b9:
            ii(0x100e_68b9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_68bd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_68bf, 2); if(jl(0x100e_68cd, 0xc)) goto l_0x100e_68cd; /* jl 0x100e68cd */
            ii(0x100e_68c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_68c4, 7); cmp(ax, memw[ds, 0x101b_8748]);         /* cmp ax, [0x101b8748] */
            ii(0x100e_68cb, 2); if(jl(0x100e_68cf, 0x2)) goto l_0x100e_68cf; /* jl 0x100e68cf */
        l_0x100e_68cd:
            ii(0x100e_68cd, 2); jmp(0x100e_68f3, 0x24); goto l_0x100e_68f3; /* jmp 0x100e68f3 */
        l_0x100e_68cf:
            ii(0x100e_68cf, 4); movsx(eax, memw[ss, ebp + 0x14]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_68d3, 1); push(eax);                              /* push eax */
            ii(0x100e_68d4, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100e_68d8, 1); push(eax);                              /* push eax */
            ii(0x100e_68d9, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100e_68dd, 1); push(eax);                              /* push eax */
            ii(0x100e_68de, 4); movsx(ecx, memw[ss, ebp - 0x18]);       /* movsx ecx, word [ebp-0x18] */
            ii(0x100e_68e2, 4); movsx(ebx, memw[ss, ebp - 0xc]);        /* movsx ebx, word [ebp-0xc] */
            ii(0x100e_68e6, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_68eb, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x100e_68ee, 5); call(/* sys */ 0x1016_a5a0, 0x8_3cad);  /* call 0x1016a5a0 */
        l_0x100e_68f3:
            ii(0x100e_68f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_68f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_68f6, 1); pop(edi);                               /* pop edi */
            ii(0x100e_68f7, 1); pop(esi);                               /* pop esi */
            ii(0x100e_68f8, 3); ret(0x8);                               /* ret 0x8 */
        }
    }
}
