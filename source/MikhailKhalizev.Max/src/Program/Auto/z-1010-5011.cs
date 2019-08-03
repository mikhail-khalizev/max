using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("92de19c6-f09e-4093-a578-019e10e7f1f7")]
        public void Method_1010_5011()
        {
            ii(0x1010_5011, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_5016, 5); calld(Definitions.sys_check_available_stack_size, 0x60d37); /* call 0x10165d52 */
            ii(0x1010_501b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_501c, 1); pushd(esi);                             /* push esi */
            ii(0x1010_501d, 1); pushd(edi);                             /* push edi */
            ii(0x1010_501e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_501f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_5021, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_5027, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_502a, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_502d, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
        l_0x1010_5030:
            ii(0x1010_5030, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5033, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1010_5036, 3); cmp(memb_a32[ds, eax], 0x7b);           /* cmp byte [eax], 0x7b */
            ii(0x1010_5039, 2); if(jnzd(0x1010_5030, -0xb)) goto l_0x1010_5030; /* jnz 0x10105030 */
            ii(0x1010_503b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_503e, 5); calld(/* sys */ 0x1017_90ce, 0x7408b);  /* call 0x101790ce */
            ii(0x1010_5043, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_5045, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5048, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
        l_0x1010_504a:
            ii(0x1010_504a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_504d, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1010_5050, 3); cmp(memb_a32[ds, eax], 0x2c);           /* cmp byte [eax], 0x2c */
            ii(0x1010_5053, 2); if(jnzd(0x1010_504a, -0xb)) goto l_0x1010_504a; /* jnz 0x1010504a */
            ii(0x1010_5055, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5058, 5); calld(/* sys */ 0x1017_90ce, 0x74071);  /* call 0x101790ce */
            ii(0x1010_505d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_505f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5062, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
        l_0x1010_5065:
            ii(0x1010_5065, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5068, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1010_506b, 3); cmp(memb_a32[ds, eax], 0x2c);           /* cmp byte [eax], 0x2c */
            ii(0x1010_506e, 2); if(jnzd(0x1010_5065, -0xb)) goto l_0x1010_5065; /* jnz 0x10105065 */
            ii(0x1010_5070, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5073, 5); calld(/* sys */ 0x1017_90ce, 0x74056);  /* call 0x101790ce */
            ii(0x1010_5078, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_507a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_507d, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
        l_0x1010_5080:
            ii(0x1010_5080, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_5083, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1010_5086, 3); cmp(memb_a32[ds, eax], 0x2c);           /* cmp byte [eax], 0x2c */
            ii(0x1010_5089, 2); if(jnzd(0x1010_5080, -0xb)) goto l_0x1010_5080; /* jnz 0x10105080 */
            ii(0x1010_508b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_508e, 5); calld(/* sys */ 0x1017_90ce, 0x7403b);  /* call 0x101790ce */
            ii(0x1010_5093, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_5095, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_5098, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x1010_509b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_509d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_509e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_509f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_50a0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_50a1, 1); retd(); return;                         /* ret */
        }
    }
}
