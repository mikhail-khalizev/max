using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a2434275-c5d1-41b0-8d1f-d5401df46489")]
        public void Method_100d_6999()
        {
            ii(0x100d_6999, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_699e, 5); calld(Definitions.sys_check_available_stack_size, 0x8_f3af); /* call 0x10165d52 */
            ii(0x100d_69a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_69a4, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_69a5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_69a6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_69a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_69a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_69aa, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_69b0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_69b3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_69b6, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_69bd, 2); if(jzd(0x100d_69d3, 0x14)) goto l_0x100d_69d3; /* jz 0x100d69d3 */
            ii(0x100d_69bf, 5); mov(edx, 0x101b_5eb4);                  /* mov edx, 0x101b5eb4 */
            ii(0x100d_69c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_69c7, 5); calld(Definitions.sys_call_dtor_arr, 0x8_f5ec); /* call 0x10165fb8 */
            ii(0x100d_69cc, 5); calld(Definitions.sys_delete_arr, 0x8_f607); /* call 0x10165fd8 */
            ii(0x100d_69d1, 2); jmpd(0x100d_6a00, 0x2d); goto l_0x100d_6a00; /* jmp 0x100d6a00 */
        l_0x100d_69d3:
            ii(0x100d_69d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_69d6, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_5f98); /* mov dword [eax+0x13], 0x101b5f98 */
            ii(0x100d_69dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_69e0, 3); cmp(memd_a32[ds, eax], 0);              /* cmp dword [eax], 0x0 */
            ii(0x100d_69e3, 2); if(jzd(0x100d_69ef, 0xa)) goto l_0x100d_69ef; /* jz 0x100d69ef */
            ii(0x100d_69e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_69e8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_69ea, 5); calld(/* sys */ 0x1016_6990, 0x8_ffa1); /* call 0x10166990 */
        l_0x100d_69ef:
            ii(0x100d_69ef, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_69f6, 2); if(jzd(0x100d_6a00, 0x8)) goto l_0x100d_6a00; /* jz 0x100d6a00 */
            ii(0x100d_69f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_69fb, 5); calld(Definitions.sys_delete, 0x8_f564); /* call 0x10165f64 */
        l_0x100d_6a00:
            ii(0x100d_6a00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6a03, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_6a06, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_6a09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6a0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6a0c, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6a0d, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6a0e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6a0f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6a10, 1); retd(); return;                         /* ret */
        }
    }
}
