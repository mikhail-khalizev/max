using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a893-1694085e")]
        public void Method_1013_a893()
        {
            ii(0x1013_a893, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_a898, 5); call(Definitions.sys_check_available_stack_size, 0x2_b4b5); /* call 0x10165d52 */
            ii(0x1013_a89d, 1); push(ebx);                              /* push ebx */
            ii(0x1013_a89e, 1); push(ecx);                              /* push ecx */
            ii(0x1013_a89f, 1); push(esi);                              /* push esi */
            ii(0x1013_a8a0, 1); push(edi);                              /* push edi */
            ii(0x1013_a8a1, 1); push(ebp);                              /* push ebp */
            ii(0x1013_a8a2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a8a4, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1013_a8aa, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_a8ad, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_a8b0, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x1013_a8b4, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a8b7, 5); call(0x1007_6d58, -0xc_3b64);           /* call 0x10076d58 */
            ii(0x1013_a8bc, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_a8bf, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x1013_a8c3, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_a8c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_a8c9, 2); if(jl(0x1013_a8d9, 0xe)) goto l_0x1013_a8d9; /* jl 0x1013a8d9 */
            ii(0x1013_a8cb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a8ce, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_a8d1, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_a8d5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_a8d7, 2); if(jl(0x1013_a8db, 0x2)) goto l_0x1013_a8db; /* jl 0x1013a8db */
        l_0x1013_a8d9:
            ii(0x1013_a8d9, 2); jmp(0x1013_a8e4, 0x9); goto l_0x1013_a8e4; /* jmp 0x1013a8e4 */
        l_0x1013_a8db:
            ii(0x1013_a8db, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1013_a8e2, 2); jmp(0x1013_a8fd, 0x19); goto l_0x1013_a8fd; /* jmp 0x1013a8fd */
        l_0x1013_a8e4:
            ii(0x1013_a8e4, 5); mov(ecx, 0xbd);                         /* mov ecx, 0xbd */
            ii(0x1013_a8e9, 5); mov(ebx, StringDefinitions.SmartlstCpp); /* mov ebx, 0x101acbf4 */
            ii(0x1013_a8ee, 5); mov(edx, StringDefinitions.IndexGreaterOrEqual0IndexLessCount); /* mov edx, 0x101acc01 */
            ii(0x1013_a8f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_a8f5, 5); call(Definitions.sys_assert, 0x2_b498); /* call 0x10165d92 */
            ii(0x1013_a8fa, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1013_a8fd:
            ii(0x1013_a8fd, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_a900, 3); movsx(edx, memw[ds, edx]);              /* movsx edx, word [edx] */
            ii(0x1013_a903, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1013_a905, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1013_a908, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1013_a90a, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1013_a90c, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_a910, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1013_a912, 2); if(jle(0x1013_a945, 0x31)) goto l_0x1013_a945; /* jle 0x1013a945 */
            ii(0x1013_a914, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_a917, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x1013_a91a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a91d, 5); call(0x1013_aa70, 0x14e);               /* call 0x1013aa70 */
            ii(0x1013_a922, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_a925, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1013_a928, 3); sub(eax, memd[ss, ebp - 0x4]);          /* sub eax, [ebp-0x4] */
            ii(0x1013_a92b, 1); dec(eax);                               /* dec eax */
            ii(0x1013_a92c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x1013_a92f:
            ii(0x1013_a92f, 3); dec(memd[ss, ebp - 0x4]);               /* dec dword [ebp-0x4] */
            ii(0x1013_a932, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1013_a937, 2); if(jz(0x1013_a943, 0xa)) goto l_0x1013_a943; /* jz 0x1013a943 */
            ii(0x1013_a939, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a93c, 5); call(0x1007_6bc0, -0xc_3d81);           /* call 0x10076bc0 */
            ii(0x1013_a941, 2); jmp(0x1013_a92f, -0x14); goto l_0x1013_a92f; /* jmp 0x1013a92f */
        l_0x1013_a943:
            ii(0x1013_a943, 2); jmp(0x1013_a967, 0x22); goto l_0x1013_a967; /* jmp 0x1013a967 */
        l_0x1013_a945:
            ii(0x1013_a945, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_a948, 3); add(edx, 0x2);                          /* add edx, 0x2 */
            ii(0x1013_a94b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a94e, 5); call(0x1013_aa70, 0x11d);               /* call 0x1013aa70 */
        l_0x1013_a953:
            ii(0x1013_a953, 3); dec(memd[ss, ebp - 0x4]);               /* dec dword [ebp-0x4] */
            ii(0x1013_a956, 5); cmp(memw[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x1013_a95b, 2); if(jz(0x1013_a967, 0xa)) goto l_0x1013_a967; /* jz 0x1013a967 */
            ii(0x1013_a95d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a960, 5); call(0x1007_6bf8, -0xc_3d6d);           /* call 0x10076bf8 */
            ii(0x1013_a965, 2); jmp(0x1013_a953, -0x14); goto l_0x1013_a953; /* jmp 0x1013a953 */
        l_0x1013_a967:
            ii(0x1013_a967, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a96a, 5); call(0x1007_6c68, -0xc_3d07);           /* call 0x10076c68 */
            ii(0x1013_a96f, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_a972, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a974, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1013_a977, 5); call(0x1007_5e24, -0xc_4b58);           /* call 0x10075e24 */
            ii(0x1013_a97c, 2); jmp(0x1013_a988, 0xa); goto l_0x1013_a988; /* jmp 0x1013a988 */
        //  ii(0x1013_a97e, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1013_a980, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //  ii(0x1013_a983, 5); call(0x1007_5e24, -0xc_4b64);           /* call 0x10075e24 */
        l_0x1013_a988:
            ii(0x1013_a988, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_a98b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a98d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_a98e, 1); pop(edi);                               /* pop edi */
            ii(0x1013_a98f, 1); pop(esi);                               /* pop esi */
            ii(0x1013_a990, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_a991, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_a992, 1); ret();                                  /* ret */
        }
    }
}
