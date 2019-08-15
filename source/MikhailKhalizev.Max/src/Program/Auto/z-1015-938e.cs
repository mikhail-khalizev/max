using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1117e93d-2dfb-4439-b16d-fffc2fe3a267")]
        public void Method_1015_938e()
        {
            ii(0x1015_938e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_9393, 5); calld(Definitions.sys_check_available_stack_size, 0xc9ba); /* call 0x10165d52 */
            ii(0x1015_9398, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_9399, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_939a, 1); pushd(edx);                             /* push edx */
            ii(0x1015_939b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_939c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_939d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_939e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_93a0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_93a6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_93a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_93ac, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1015_93b0, 2); if(jnzd(0x1015_93bb, 0x9)) goto l_0x1015_93bb; /* jnz 0x101593bb */
            ii(0x1015_93b2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_93b5, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1015_93b9, 2); if(jzd(0x1015_93bd, 0x2)) goto l_0x1015_93bd; /* jz 0x101593bd */
        l_0x1015_93bb:
            ii(0x1015_93bb, 2); jmpd(0x1015_93c3, 0x6); goto l_0x1015_93c3; /* jmp 0x101593c3 */
        l_0x1015_93bd:
            ii(0x1015_93bd, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_93c1, 2); jmpd(0x1015_93ce, 0xb); goto l_0x1015_93ce; /* jmp 0x101593ce */
        l_0x1015_93c3:
            ii(0x1015_93c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_93c6, 5); calld(0x1015_7c72, -0x1759);            /* call 0x10157c72 */
            ii(0x1015_93cb, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1015_93ce:
            ii(0x1015_93ce, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_93d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_93d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_93d4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_93d5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_93d6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_93d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_93d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_93d9, 1); retd(); return;                         /* ret */
        }
    }
}
