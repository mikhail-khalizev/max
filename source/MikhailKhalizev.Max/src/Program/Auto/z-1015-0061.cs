using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_0061-c2dc6af1")]
        public void Method_1015_0061()
        {
            ii(0x1015_0061, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_0066, 5); calld(Definitions.sys_check_available_stack_size, 0x1_5ce7); /* call 0x10165d52 */
            ii(0x1015_006b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_006c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_006d, 1); pushd(esi);                             /* push esi */
            ii(0x1015_006e, 1); pushd(edi);                             /* push edi */
            ii(0x1015_006f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_0070, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_0072, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_0078, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_007b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_007e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_0081, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1015_0084, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_0087, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1015_008a, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x3); /* cmp byte [eax+0x101c81d5], 0x3 */
            ii(0x1015_0091, 6); if(jnzd(0x1015_0125, 0x8e)) goto l_0x1015_0125; /* jnz 0x10150125 */
            ii(0x1015_0097, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_009a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_009d, 4); add(memw_a32[ds, edx + 0x52], ax);      /* add [edx+0x52], ax */
            ii(0x1015_00a1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_00a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00a6, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_00a9, 5); calld(0x1013_ad71, -0x1_533d);          /* call 0x1013ad71 */
            ii(0x1015_00ae, 2); test(al, al);                           /* test al, al */
            ii(0x1015_00b0, 2); if(jzd(0x1015_0125, 0x73)) goto l_0x1015_0125; /* jz 0x10150125 */
            ii(0x1015_00b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00b5, 5); calld(0x1007_623c, -0xd_9e7e);          /* call 0x1007623c */
            ii(0x1015_00ba, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1015_00be, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_00c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00c4, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_00c7, 5); calld(0x1007_6884, -0xd_9848);          /* call 0x10076884 */
            ii(0x1015_00cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_00ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_00d1, 4); add(memw_a32[ds, edx + 0xc], ax);       /* add [edx+0xc], ax */
            ii(0x1015_00d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00d8, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1015_00dc, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1015_00e0, 2); if(jled(0x1015_0125, 0x43)) goto l_0x1015_0125; /* jle 0x10150125 */
            ii(0x1015_00e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00e5, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1015_00e9, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1015_00ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_00ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_00f2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1015_00f5, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1015_00f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_00fc, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_00ff, 5); calld(0x1007_6884, -0xd_9880);          /* call 0x10076884 */
            ii(0x1015_0104, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_0106, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_0109, 4); sub(memw_a32[ds, edx + 0xc], ax);       /* sub [edx+0xc], ax */
            ii(0x1015_010d, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x1015_0111, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_0113, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_0115, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_0118, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1015_011b, 5); calld(0x1015_5314, 0x51f4);             /* call 0x10155314 */
            ii(0x1015_0120, 5); calld(0x100d_7a9c, -0x7_8689);          /* call 0x100d7a9c */
        l_0x1015_0125:
            ii(0x1015_0125, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_0127, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_0128, 1); popd(edi);                              /* pop edi */
            ii(0x1015_0129, 1); popd(esi);                              /* pop esi */
            ii(0x1015_012a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_012b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_012c, 1); retd(); return;                         /* ret */
        }
    }
}
