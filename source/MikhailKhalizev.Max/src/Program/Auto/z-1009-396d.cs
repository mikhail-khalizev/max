using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("44b5e52a-7f68-44e2-b941-d229e49aea62")]
        public void Method_1009_396d()
        {
            ii(0x1009_396d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_3972, 5); calld(Definitions.sys_check_available_stack_size, 0xd_23db); /* call 0x10165d52 */
            ii(0x1009_3977, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_3978, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_3979, 1); pushd(esi);                             /* push esi */
            ii(0x1009_397a, 1); pushd(edi);                             /* push edi */
            ii(0x1009_397b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_397c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_397e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_3984, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_3987, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_398a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_398d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_3990, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_3993, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_3996, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_3999, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x1009_399c, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x1009_399e, 2); if(jnzd(0x1009_39ae, 0xe)) goto l_0x1009_39ae; /* jnz 0x100939ae */
            ii(0x1009_39a0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_39a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_39a6, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_39a9, 5); calld(0x1009_c660, 0x8cb2);             /* call 0x1009c660 */
        l_0x1009_39ae:
            ii(0x1009_39ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_39b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_39b1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_39b2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_39b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_39b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_39b5, 1); retd(); return;                         /* ret */
        }
    }
}