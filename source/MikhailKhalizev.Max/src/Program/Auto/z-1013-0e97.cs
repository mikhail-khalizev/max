using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c16c6cb7-2b3b-46e6-94e5-866708713cfe")]
        public void Method_1013_0e97()
        {
            ii(0x1013_0e97, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_0e9c, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4eb1); /* call 0x10165d52 */
            ii(0x1013_0ea1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0ea2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0ea3, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0ea4, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0ea5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0ea6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0ea8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0eae, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0eb1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_0eb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_0eb7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_0eba, 7); mov(memb_a32[ds, 0x101b_b48d], 0x1);    /* mov byte [0x101bb48d], 0x1 */
            ii(0x1013_0ec1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0ec4, 5); calld(0x1012_f003, -0x1ec6);            /* call 0x1012f003 */
            ii(0x1013_0ec9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0ecc, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0ed0, 2); if(jzd(0x1013_0edb, 0x9)) goto l_0x1013_0edb; /* jz 0x10130edb */
            ii(0x1013_0ed2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0ed5, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0ed9, 2); if(jnzd(0x1013_0ee8, 0xd)) goto l_0x1013_0ee8; /* jnz 0x10130ee8 */
        l_0x1013_0edb:
            ii(0x1013_0edb, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_0ee0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_0ee3, 5); calld(0x1013_0c16, -0x2d2);             /* call 0x10130c16 */
        l_0x1013_0ee8:
            ii(0x1013_0ee8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0eea, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0eeb, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0eec, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0eed, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0eee, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0eef, 1); retd(); return;                         /* ret */
        }
    }
}