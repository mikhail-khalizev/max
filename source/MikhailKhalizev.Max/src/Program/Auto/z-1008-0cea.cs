using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d74ebba-c1b5-4fae-bfeb-0fe800abe834")]
        public void Method_1008_0cea()
        {
            ii(0x1008_0cea, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_0cef, 5); calld(Definitions.sys_check_available_stack_size, 0xe_505e); /* call 0x10165d52 */
            ii(0x1008_0cf4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_0cf5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_0cf6, 1); pushd(edx);                             /* push edx */
            ii(0x1008_0cf7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_0cf8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0cf9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_0cfa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0cfc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_0d02, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_0d05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0d08, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_0d0b, 5); calld(0x1007_6338, -0xa9d8);            /* call 0x10076338 */
            ii(0x1008_0d10, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1008_0d13, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0d15, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_0d17, 5); calld(0x1007_64b8, -0xa864);            /* call 0x100764b8 */
            ii(0x1008_0d1c, 2); jmpd(0x1008_0d26, 0x8); goto l_0x1008_0d26; /* jmp 0x10080d26 */
        l_0x1008_0d1e:
            ii(0x1008_0d1e, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0d21, 5); calld(0x1007_6bf8, -0xa12e);            /* call 0x10076bf8 */
        l_0x1008_0d26:
            ii(0x1008_0d26, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0d28, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0d2b, 5); calld(0x1013_ad71, 0xb_a041);           /* call 0x1013ad71 */
            ii(0x1008_0d30, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0d32, 2); if(jzd(0x1008_0d62, 0x2e)) goto l_0x1008_0d62; /* jz 0x10080d62 */
            ii(0x1008_0d34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_0d37, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_0d3a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_0d3d, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_0d40, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0d43, 5); calld(0x1007_63d4, -0xa974);            /* call 0x100763d4 */
            ii(0x1008_0d48, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_0d4a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_0d4d, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x1008_0d50, 2); test(al, al);                           /* test al, al */
            ii(0x1008_0d52, 2); if(jzd(0x1008_0d60, 0xc)) goto l_0x1008_0d60; /* jz 0x10080d60 */
            ii(0x1008_0d54, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0d56, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0d59, 5); calld(0x1007_5f6c, -0xadf2);            /* call 0x10075f6c */
            ii(0x1008_0d5e, 2); jmpd(0x1008_0d6c, 0xc); goto l_0x1008_0d6c; /* jmp 0x10080d6c */
        l_0x1008_0d60:
            ii(0x1008_0d60, 2); jmpd(0x1008_0d1e, -0x44); goto l_0x1008_0d1e; /* jmp 0x10080d1e */
        l_0x1008_0d62:
            ii(0x1008_0d62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_0d64, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_0d67, 5); calld(0x1007_5f6c, -0xae00);            /* call 0x10075f6c */
        l_0x1008_0d6c:
            ii(0x1008_0d6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_0d6e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_0d6f, 1); popd(edi);                              /* pop edi */
            ii(0x1008_0d70, 1); popd(esi);                              /* pop esi */
            ii(0x1008_0d71, 1); popd(edx);                              /* pop edx */
            ii(0x1008_0d72, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_0d73, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_0d74, 1); retd(); return;                         /* ret */
        }
    }
}
