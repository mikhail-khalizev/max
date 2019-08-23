using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5034-5a019c2")]
        public void Method_1007_5034()
        {
            ii(0x1007_5034, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_5039, 5); call(Definitions.sys_check_available_stack_size, 0xf_0d14); /* call 0x10165d52 */
            ii(0x1007_503e, 1); push(ebx);                              /* push ebx */
            ii(0x1007_503f, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5040, 1); push(esi);                              /* push esi */
            ii(0x1007_5041, 1); push(edi);                              /* push edi */
            ii(0x1007_5042, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5043, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5045, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_504b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_504e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5051, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_5055, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_5057, 2); if(jl(0x1007_5065, 0xc)) goto l_0x1007_5065; /* jl 0x10075065 */
            ii(0x1007_5059, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_505c, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1007_5063, 2); if(jl(0x1007_5067, 0x2)) goto l_0x1007_5067; /* jl 0x10075067 */
        l_0x1007_5065:
            ii(0x1007_5065, 2); jmp(0x1007_506f, 0x8); goto l_0x1007_506f; /* jmp 0x1007506f */
        l_0x1007_5067:
            ii(0x1007_5067, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_506b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_506d, 2); if(jge(0x1007_5071, 0x2)) goto l_0x1007_5071; /* jge 0x10075071 */
        l_0x1007_506f:
            ii(0x1007_506f, 2); jmp(0x1007_507d, 0xc); goto l_0x1007_507d; /* jmp 0x1007507d */
        l_0x1007_5071:
            ii(0x1007_5071, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_5074, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1007_507b, 2); if(jl(0x1007_5089, 0xc)) goto l_0x1007_5089; /* jl 0x10075089 */
        l_0x1007_507d:
            ii(0x1007_507d, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_5084, 5); jmp(0x1007_5100, 0x77); goto l_0x1007_5100; /* jmp 0x10075100 */
        l_0x1007_5089:
            ii(0x1007_5089, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_508d, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_5091, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1007_5096, 5); call(0x1010_3541, 0x8_e4a6);            /* call 0x10103541 */
            ii(0x1007_509b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_509d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50a0, 5); call(0x1007_64b8, 0x1413);              /* call 0x100764b8 */
        l_0x1007_50a5:
            ii(0x1007_50a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_50a7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50aa, 5); call(0x1013_ad71, 0xc_5cc2);            /* call 0x1013ad71 */
            ii(0x1007_50af, 2); test(al, al);                           /* test al, al */
            ii(0x1007_50b1, 2); if(jz(0x1007_50e3, 0x30)) goto l_0x1007_50e3; /* jz 0x100750e3 */
            ii(0x1007_50b3, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50b6, 5); call(0x1007_63a0, 0x12e5);              /* call 0x100763a0 */
            ii(0x1007_50bb, 5); cmp(memw[ds, eax + 0x8], 0x27);         /* cmp word [eax+0x8], 0x27 */
            ii(0x1007_50c0, 2); if(jnz(0x1007_50d9, 0x17)) goto l_0x1007_50d9; /* jnz 0x100750d9 */
            ii(0x1007_50c2, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50c5, 5); call(0x1007_6408, 0x133e);              /* call 0x10076408 */
            ii(0x1007_50ca, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_50cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_50cf, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50d2, 5); call(0x1007_5f6c, 0xe95);               /* call 0x10075f6c */
            ii(0x1007_50d7, 2); jmp(0x1007_5100, 0x27); goto l_0x1007_5100; /* jmp 0x10075100 */
        l_0x1007_50d9:
            ii(0x1007_50d9, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50dc, 5); call(0x1007_6bf8, 0x1b17);              /* call 0x10076bf8 */
            ii(0x1007_50e1, 2); jmp(0x1007_50a5, -0x3e); goto l_0x1007_50a5; /* jmp 0x100750a5 */
        l_0x1007_50e3:
            ii(0x1007_50e3, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_50ea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_50ec, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_50ef, 5); call(0x1007_5f6c, 0xe78);               /* call 0x10075f6c */
            ii(0x1007_50f4, 2); jmp(0x1007_5100, 0xa); goto l_0x1007_5100; /* jmp 0x10075100 */
        //  ii(0x1007_50f6, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_50f8, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
        //  ii(0x1007_50fb, 5); call(0x1007_5f6c, 0xe6c);               /* call 0x10075f6c */
        l_0x1007_5100:
            ii(0x1007_5100, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_5103, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5105, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5106, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5107, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5108, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5109, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_510a, 1); ret();                                  /* ret */
        }
    }
}
