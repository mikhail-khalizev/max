using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("57ae3c25-045a-4d4e-aac9-10de7f4023b2")]
        public void Method_100e_b7c9()
        {
            ii(0x100e_b7c9, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b7ce, 5); calld(Definitions.sys_check_available_stack_size, 0x7_a57f); /* call 0x10165d52 */
            ii(0x100e_b7d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b7d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b7d5, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b7d6, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b7d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b7d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b7da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_b7e0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_b7e3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_b7e6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b7e9, 4); mov(memb_a32[ds, eax + 0x32], 0);       /* mov byte [eax+0x32], 0x0 */
            ii(0x100e_b7ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b7f0, 4); mov(memb_a32[ds, eax + 0x2b], 0);       /* mov byte [eax+0x2b], 0x0 */
            ii(0x100e_b7f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b7f7, 5); calld(0x100e_b6bf, -0x13d);             /* call 0x100eb6bf */
            ii(0x100e_b7fc, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_b800, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_b802, 2); if(jged(0x100e_b80b, 0x7)) goto l_0x100e_b80b; /* jge 0x100eb80b */
            ii(0x100e_b804, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x100e_b80b:
            ii(0x100e_b80b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b80e, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b811, 5); calld(Definitions.sys_strlen, 0x8_66b1); /* call 0x10171ec7 */
            ii(0x100e_b816, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_b81a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_b81c, 2); if(jbed(0x100e_b82c, 0xe)) goto l_0x100e_b82c; /* jbe 0x100eb82c */
            ii(0x100e_b81e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b821, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b824, 5); calld(Definitions.sys_strlen, 0x8_669e); /* call 0x10171ec7 */
            ii(0x100e_b829, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x100e_b82c:
            ii(0x100e_b82c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b82f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_b832, 4); mov(memw_a32[ds, edx + 0x2c], ax);      /* mov [edx+0x2c], ax */
            ii(0x100e_b836, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b839, 4); mov(memb_a32[ds, eax + 0x2b], 0x1);     /* mov byte [eax+0x2b], 0x1 */
            ii(0x100e_b83d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_b840, 5); calld(0x100e_b6bf, -0x186);             /* call 0x100eb6bf */
            ii(0x100e_b845, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b847, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b848, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b849, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b84a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b84b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b84c, 1); retd(); return;                         /* ret */
        }
    }
}
