using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_630a-4d013d83")]
        public void Method_1014_630a()
        {
            ii(0x1014_630a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_630f, 5); calld(Definitions.sys_check_available_stack_size, 0x1_fa3e); /* call 0x10165d52 */
            ii(0x1014_6314, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_6315, 1); pushd(esi);                             /* push esi */
            ii(0x1014_6316, 1); pushd(edi);                             /* push edi */
            ii(0x1014_6317, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_6318, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_631a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_6320, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_6323, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_6326, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1014_6329, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_632c, 3); add(eax, 0x1c);                         /* add eax, 0x1c */
            ii(0x1014_632f, 5); calld(0x1014_7ea0, 0x1b6c);             /* call 0x10147ea0 */
            ii(0x1014_6334, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x1014_6337, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6339, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_633b, 5); calld(0x1014_7dbc, 0x1a7c);             /* call 0x10147dbc */
            ii(0x1014_6340, 2); jmpd(0x1014_634a, 0x8); goto l_0x1014_634a; /* jmp 0x1014634a */
        l_0x1014_6342:
            ii(0x1014_6342, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_6345, 5); calld(0x1007_6bf8, -0xc_f752);          /* call 0x10076bf8 */
        l_0x1014_634a:
            ii(0x1014_634a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_634c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_634f, 5); calld(0x1013_ad71, -0xb5e3);            /* call 0x1013ad71 */
            ii(0x1014_6354, 2); test(al, al);                           /* test al, al */
            ii(0x1014_6356, 2); if(jzd(0x1014_63ab, 0x53)) goto l_0x1014_63ab; /* jz 0x101463ab */
            ii(0x1014_6358, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_635b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_635e, 5); calld(0x1014_7ce0, 0x197d);             /* call 0x10147ce0 */
            ii(0x1014_6363, 5); calld(0x1014_7f88, 0x1c20);             /* call 0x10147f88 */
            ii(0x1014_6368, 5); calld(Definitions.sys_strcasecmp, 0x1_fdc3); /* call 0x10166130 */
            ii(0x1014_636d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_636f, 2); if(jnzd(0x1014_63a9, 0x38)) goto l_0x1014_63a9; /* jnz 0x101463a9 */
            ii(0x1014_6371, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_6374, 5); calld(0x1014_7d48, 0x19cf);             /* call 0x10147d48 */
            ii(0x1014_6379, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1014_637c, 3); add(ebx, 0x1c);                         /* add ebx, 0x1c */
            ii(0x1014_637f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6381, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_6383, 5); calld(0x1014_7e40, 0x1ab8);             /* call 0x10147e40 */
            ii(0x1014_6388, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_638b, 5); calld(0x1014_7d14, 0x1984);             /* call 0x10147d14 */
            ii(0x1014_6390, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_6392, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6395, 5); calld(0x1014_7f44, 0x1baa);             /* call 0x10147f44 */
            ii(0x1014_639a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_639c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_639f, 5); calld(0x1014_78cc, 0x1528);             /* call 0x101478cc */
            ii(0x1014_63a4, 5); jmpd(0x1014_642b, 0x82); goto l_0x1014_642b; /* jmp 0x1014642b */
        l_0x1014_63a9:
            ii(0x1014_63a9, 2); jmpd(0x1014_6342, -0x69); goto l_0x1014_6342; /* jmp 0x10146342 */
        l_0x1014_63ab:
            ii(0x1014_63ab, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_63ae, 5); calld(0x1014_6462, 0xaf);               /* call 0x10146462 */
            ii(0x1014_63b3, 2); test(al, al);                           /* test al, al */
            ii(0x1014_63b5, 2); if(jzd(0x1014_640b, 0x54)) goto l_0x1014_640b; /* jz 0x1014640b */
            ii(0x1014_63b7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_63ba, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_63bd, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_63c0, 5); calld(0x100e_0760, -0x6_5c65);          /* call 0x100e0760 */
            ii(0x1014_63c5, 5); calld(0x1014_7f88, 0x1bbe);             /* call 0x10147f88 */
            ii(0x1014_63ca, 5); calld(Definitions.sys_strcasecmp, 0x1_fd61); /* call 0x10166130 */
            ii(0x1014_63cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_63d1, 2); if(jzd(0x1014_63ef, 0x1c)) goto l_0x1014_63ef; /* jz 0x101463ef */
            ii(0x1014_63d3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_63d6, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1014_63d9, 5); calld(0x1014_7f14, 0x1b36);             /* call 0x10147f14 */
            ii(0x1014_63de, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1014_63e1, 3); add(ebx, 0x1c);                         /* add ebx, 0x1c */
            ii(0x1014_63e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_63e6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_63e8, 5); calld(0x1014_7e70, 0x1a83);             /* call 0x10147e70 */
            ii(0x1014_63ed, 2); jmpd(0x1014_6409, 0x1a); goto l_0x1014_6409; /* jmp 0x10146409 */
        l_0x1014_63ef:
            ii(0x1014_63ef, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1014_63f2, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1014_63f5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_63f8, 5); calld(0x100e_07f4, -0x6_5c09);          /* call 0x100e07f4 */
            ii(0x1014_63fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_63ff, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_6402, 5); calld(0x1014_78cc, 0x14c5);             /* call 0x101478cc */
            ii(0x1014_6407, 2); jmpd(0x1014_642b, 0x22); goto l_0x1014_642b; /* jmp 0x1014642b */
        l_0x1014_6409:
            ii(0x1014_6409, 2); jmpd(0x1014_63ab, -0x60); goto l_0x1014_63ab; /* jmp 0x101463ab */
        l_0x1014_640b:
            ii(0x1014_640b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_640d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_6410, 5); calld(0x1014_7f44, 0x1b2f);             /* call 0x10147f44 */
            ii(0x1014_6415, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_6417, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_641a, 5); calld(0x1014_78cc, 0x14ad);             /* call 0x101478cc */
            ii(0x1014_641f, 2); jmpd(0x1014_642b, 0xa); goto l_0x1014_642b; /* jmp 0x1014642b */
        //    ii(0x1014_6421, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1014_6423, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
        //    ii(0x1014_6426, 5); calld(0x1014_78cc, 0x14a1);             /* call 0x101478cc */
        l_0x1014_642b:
            ii(0x1014_642b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_642e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_6430, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_6431, 1); popd(edi);                              /* pop edi */
            ii(0x1014_6432, 1); popd(esi);                              /* pop esi */
            ii(0x1014_6433, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_6434, 1); retd(); return;                         /* ret */
        }
    }
}
