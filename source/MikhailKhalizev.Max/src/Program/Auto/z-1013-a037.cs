using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a037-173a326e")]
        public void Method_1013_a037()
        {
            ii(0x1013_a037, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_a03c, 5); calld(Definitions.sys_check_available_stack_size, 0x2_bd11); /* call 0x10165d52 */
            ii(0x1013_a041, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a042, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a043, 1); pushd(edx);                             /* push edx */
            ii(0x1013_a044, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a045, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a046, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a047, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a049, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_a04f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_a052, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a054, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a057, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a05a, 5); calld(0x1013_ad71, 0xd12);              /* call 0x1013ad71 */
            ii(0x1013_a05f, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a061, 2); if(jzd(0x1013_a07c, 0x19)) goto l_0x1013_a07c; /* jz 0x1013a07c */
            ii(0x1013_a063, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a066, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1013_a069, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a06c, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a06f, 5); calld(0x1013_aa3c, 0x9c8);              /* call 0x1013aa3c */
            ii(0x1013_a074, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a077, 5); calld(0x1013_aa70, 0x9f4);              /* call 0x1013aa70 */
        l_0x1013_a07c:
            ii(0x1013_a07c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_a07e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a081, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a084, 5); calld(0x1013_ad71, 0xce8);              /* call 0x1013ad71 */
            ii(0x1013_a089, 2); test(al, al);                           /* test al, al */
            ii(0x1013_a08b, 2); if(jzd(0x1013_a0a6, 0x19)) goto l_0x1013_a0a6; /* jz 0x1013a0a6 */
            ii(0x1013_a08d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_a090, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1013_a093, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a096, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_a099, 5); calld(0x1013_aa3c, 0x99e);              /* call 0x1013aa3c */
            ii(0x1013_a09e, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_a0a1, 5); calld(0x1013_aa70, 0x9ca);              /* call 0x1013aa70 */
        l_0x1013_a0a6:
            ii(0x1013_a0a6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a0a8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a0a9, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a0aa, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a0ab, 1); popd(edx);                              /* pop edx */
            ii(0x1013_a0ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a0ad, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a0ae, 1); retd();                                 /* ret */
        }
    }
}
