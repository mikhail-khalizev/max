using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f382-838d25ff")]
        public void Method_1010_f382()
        {
            ii(0x1010_f382, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_f387, 5); calld(Definitions.sys_check_available_stack_size, 0x5_69c6); /* call 0x10165d52 */
            ii(0x1010_f38c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f38d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f38e, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f38f, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f390, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f391, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f392, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f394, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_f39a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f39d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f3a0, 5); add(eax, 0x107);                        /* add eax, 0x107 */
            ii(0x1010_f3a5, 5); calld(/* sys */ 0x1017_90ce, 0x6_9d24); /* call 0x101790ce */
            ii(0x1010_f3aa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_f3ac, 5); mov(eax, 0x5b);                         /* mov eax, 0x5b */
            ii(0x1010_f3b1, 5); calld(0x100c_aafc, -0x4_48ba);          /* call 0x100caafc */
            ii(0x1010_f3b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f3b9, 5); add(eax, 0x143);                        /* add eax, 0x143 */
            ii(0x1010_f3be, 5); calld(/* sys */ 0x1017_90ce, 0x6_9d0b); /* call 0x101790ce */
            ii(0x1010_f3c3, 5); mov(ebx, 0x5c);                         /* mov ebx, 0x5c */
            ii(0x1010_f3c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_f3ca, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_f3cc, 5); calld(0x100c_aafc, -0x4_48d5);          /* call 0x100caafc */
            ii(0x1010_f3d1, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f3d4, 6); add(ebx, 0x125);                        /* add ebx, 0x125 */
            ii(0x1010_f3da, 5); mov(edx, 0x5a);                         /* mov edx, 0x5a */
            ii(0x1010_f3df, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f3e4, 5); calld(0x1010_6205, -0x91e4);            /* call 0x10106205 */
            ii(0x1010_f3e9, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f3ec, 6); add(ebx, 0x161);                        /* add ebx, 0x161 */
            ii(0x1010_f3f2, 5); mov(edx, 0x5d);                         /* mov edx, 0x5d */
            ii(0x1010_f3f7, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f3fc, 5); calld(0x1010_6205, -0x91fc);            /* call 0x10106205 */
            ii(0x1010_f401, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f404, 6); add(ebx, 0x17f);                        /* add ebx, 0x17f */
            ii(0x1010_f40a, 5); mov(edx, 0x5e);                         /* mov edx, 0x5e */
            ii(0x1010_f40f, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f414, 5); calld(0x1010_6205, -0x9214);            /* call 0x10106205 */
            ii(0x1010_f419, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f41c, 6); add(ebx, 0x19d);                        /* add ebx, 0x19d */
            ii(0x1010_f422, 5); mov(edx, 0x5f);                         /* mov edx, 0x5f */
            ii(0x1010_f427, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f42c, 5); calld(0x1010_6205, -0x922c);            /* call 0x10106205 */
            ii(0x1010_f431, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_f434, 6); add(ebx, 0x1bb);                        /* add ebx, 0x1bb */
            ii(0x1010_f43a, 5); mov(edx, 0x61);                         /* mov edx, 0x61 */
            ii(0x1010_f43f, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_f444, 5); calld(0x1010_6205, -0x9244);            /* call 0x10106205 */
            ii(0x1010_f449, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f44b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f44c, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f44d, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f44e, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f44f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f450, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f451, 1); retd();                                 /* ret */
        }
    }
}
