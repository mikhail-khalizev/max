using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3330-bf5e8927")]
        public void Method_1013_3330()
        {
            ii(0x1013_3330, 5); pushd(0x60);                            /* push 0x60 */
            ii(0x1013_3335, 5); calld(Definitions.sys_check_available_stack_size, 0x3_2a18); /* call 0x10165d52 */
            ii(0x1013_333a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_333b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_333c, 1); pushd(esi);                             /* push esi */
            ii(0x1013_333d, 1); pushd(edi);                             /* push edi */
            ii(0x1013_333e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_333f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3341, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1013_3347, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_334a, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_334d, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_3351, 6); imul(edx, eax, 0x247);                  /* imul edx, eax, 0x247 */
            ii(0x1013_3357, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_335b, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1013_335e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1013_3360, 7); mov(ax, memw_a32[ds, eax + 0x101c_a4f0]); /* mov ax, [eax+0x101ca4f0] */
            ii(0x1013_3367, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_336a, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_336e, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1013_3374, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1013_337a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_337d, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_3384, 2); if(jmpd_func(0x1013_338c, 0x6)) return; /* jmp 0x1013338c */
        }
    }
}
