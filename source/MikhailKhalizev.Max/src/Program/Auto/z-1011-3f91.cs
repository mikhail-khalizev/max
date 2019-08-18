using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_3f91-2cac50a0")]
        public void Method_1011_3f91()
        {
            ii(0x1011_3f91, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_3f96, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1db7); /* call 0x10165d52 */
            ii(0x1011_3f9b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_3f9c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_3f9d, 1); pushd(esi);                             /* push esi */
            ii(0x1011_3f9e, 1); pushd(edi);                             /* push edi */
            ii(0x1011_3f9f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_3fa0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_3fa2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_3fa8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_3fab, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_3fae, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1011_3fb5:
            ii(0x1011_3fb5, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_3fb9, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1011_3fbc, 6); mov(al, memb_a32[ds, eax + 0x9c]);      /* mov al, [eax+0x9c] */
            ii(0x1011_3fc2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_3fc7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1011_3fca, 2); if(jzd(0x1011_3fd8, 0xc)) goto l_0x1011_3fd8; /* jz 0x10113fd8 */
            ii(0x1011_3fcc, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1011_3fcf, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1011_3fd3, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1011_3fd6, 2); if(jnzd(0x1011_3fb5, -0x23)) goto l_0x1011_3fb5; /* jnz 0x10113fb5 */
        l_0x1011_3fd8:
            ii(0x1011_3fd8, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_3fdc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_3fdf, 5); calld(0x1011_3d56, -0x28e);             /* call 0x10113d56 */
            ii(0x1011_3fe4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3fe6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_3fe7, 1); popd(edi);                              /* pop edi */
            ii(0x1011_3fe8, 1); popd(esi);                              /* pop esi */
            ii(0x1011_3fe9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_3fea, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_3feb, 1); retd(); return;                         /* ret */
        }
    }
}
