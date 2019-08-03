using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("22d7648a-c94b-4ae0-9755-30bd8940a953")]
        public void Method_1013_9f45()
        {
            ii(0x1013_9f45, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_9f4a, 5); calld(Definitions.sys_check_available_stack_size, 0x2be03); /* call 0x10165d52 */
            ii(0x1013_9f4f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_9f50, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_9f51, 1); pushd(esi);                             /* push esi */
            ii(0x1013_9f52, 1); pushd(edi);                             /* push edi */
            ii(0x1013_9f53, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_9f54, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9f56, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_9f5c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_9f5f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_9f62, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_9f65, 3); add(edx, 0xa);                          /* add edx, 0xa */
            ii(0x1013_9f68, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9f6b, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9f6e, 5); calld(0x1013_aa70, 0xafd);              /* call 0x1013aa70 */
            ii(0x1013_9f73, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_9f76, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_9f79, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9f7c, 5); calld(0x1007_6c98, -0xc32e9);           /* call 0x10076c98 */
            ii(0x1013_9f81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_9f83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9f86, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9f89, 5); calld(0x1013_ad71, 0xde3);              /* call 0x1013ad71 */
            ii(0x1013_9f8e, 2); test(al, al);                           /* test al, al */
            ii(0x1013_9f90, 2); if(jzd(0x1013_9fa8, 0x16)) goto l_0x1013_9fa8; /* jz 0x10139fa8 */
            ii(0x1013_9f92, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_9f95, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9f98, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9f9b, 5); calld(0x1013_aa3c, 0xa9c);              /* call 0x1013aa3c */
            ii(0x1013_9fa0, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1013_9fa3, 5); calld(0x1007_6c98, -0xc3310);           /* call 0x10076c98 */
        l_0x1013_9fa8:
            ii(0x1013_9fa8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_9fab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_9fae, 3); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x1013_9fb1, 5); calld(0x1007_6c98, -0xc331e);           /* call 0x10076c98 */
            ii(0x1013_9fb6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9fb8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_9fb9, 1); popd(edi);                              /* pop edi */
            ii(0x1013_9fba, 1); popd(esi);                              /* pop esi */
            ii(0x1013_9fbb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_9fbc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_9fbd, 1); retd(); return;                         /* ret */
        }
    }
}