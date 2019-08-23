using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_73de-40143040")]
        public void Method_1014_73de()
        {
            ii(0x1014_73de, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_73e3, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e96a); /* call 0x10165d52 */
            ii(0x1014_73e8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_73e9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_73ea, 1); pushd(esi);                             /* push esi */
            ii(0x1014_73eb, 1); pushd(edi);                             /* push edi */
            ii(0x1014_73ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_73ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_73ef, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_73f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_73f8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_73fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_73fe, 5); calld(0x1014_7395, -0x6e);              /* call 0x10147395 */
            ii(0x1014_7403, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7406, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7408, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_740b, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9b3d); /* call 0x10180f4d */
            ii(0x1014_7410, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7413, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7415, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1014_741a, 5); calld(/* sys */ 0x1017_29f1, 0x2_b5d2); /* call 0x101729f1 */
            ii(0x1014_741f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7422, 5); calld(0x1014_7395, -0x92);              /* call 0x10147395 */
            ii(0x1014_7427, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_742a, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_742c, 5); mov(eax, StringDefinitions.Control34);  /* mov eax, 0x101ad11b */
            ii(0x1014_7431, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9b17); /* call 0x10180f4d */
            ii(0x1014_7436, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7439, 5); add(memw_a32[ds, eax + 0xe], 0x2);      /* add word [eax+0xe], 0x2 */
            ii(0x1014_743e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7440, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7441, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7442, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7443, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7444, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7445, 1); retd();                                 /* ret */
        }
    }
}
