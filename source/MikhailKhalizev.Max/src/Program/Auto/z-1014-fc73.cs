using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7955f906-0c5d-475c-ac64-93fb1e62bfc0")]
        public void Method_1014_fc73()
        {
            ii(0x1014_fc73, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_fc78, 5); calld(Definitions.sys_check_available_stack_size, 0x1_60d5); /* call 0x10165d52 */
            ii(0x1014_fc7d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_fc7e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_fc7f, 1); pushd(esi);                             /* push esi */
            ii(0x1014_fc80, 1); pushd(edi);                             /* push edi */
            ii(0x1014_fc81, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_fc82, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fc84, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_fc8a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_fc8d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_fc90, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fc93, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_fc96, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fc99, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fc9c, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1014_fca3, 6); if(jnzd(0x1014_fd37, 0x8e)) goto l_0x1014_fd37; /* jnz 0x1014fd37 */
            ii(0x1014_fca9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fcac, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_fcaf, 4); add(memw_a32[ds, edx + 0x52], ax);      /* add [edx+0x52], ax */
            ii(0x1014_fcb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_fcb5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fcb8, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fcbb, 5); calld(0x1013_ad71, -0x1_4f4f);          /* call 0x1013ad71 */
            ii(0x1014_fcc0, 2); test(al, al);                           /* test al, al */
            ii(0x1014_fcc2, 2); if(jzd(0x1014_fd37, 0x73)) goto l_0x1014_fd37; /* jz 0x1014fd37 */
            ii(0x1014_fcc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fcc7, 5); calld(0x1007_623c, -0xd_9a90);          /* call 0x1007623c */
            ii(0x1014_fccc, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1014_fcd0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_fcd3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fcd6, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fcd9, 5); calld(0x1007_6884, -0xd_945a);          /* call 0x10076884 */
            ii(0x1014_fcde, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_fce0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fce3, 4); add(memw_a32[ds, edx + 0x8], ax);       /* add [edx+0x8], ax */
            ii(0x1014_fce7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fcea, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fcee, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1014_fcf2, 2); if(jled(0x1014_fd37, 0x43)) goto l_0x1014_fd37; /* jle 0x1014fd37 */
            ii(0x1014_fcf4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fcf7, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fcfb, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1014_fcfe, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_fd01, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_fd04, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_fd07, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1014_fd0b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fd0e, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fd11, 5); calld(0x1007_6884, -0xd_9492);          /* call 0x10076884 */
            ii(0x1014_fd16, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_fd18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fd1b, 4); sub(memw_a32[ds, edx + 0x8], ax);       /* sub [edx+0x8], ax */
            ii(0x1014_fd1f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_fd21, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_fd23, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_fd27, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fd2a, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fd2d, 5); calld(0x1015_5314, 0x55e2);             /* call 0x10155314 */
            ii(0x1014_fd32, 5); calld(0x100d_7a9c, -0x7_829b);          /* call 0x100d7a9c */
        l_0x1014_fd37:
            ii(0x1014_fd37, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_fd39, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_fd3a, 1); popd(edi);                              /* pop edi */
            ii(0x1014_fd3b, 1); popd(esi);                              /* pop esi */
            ii(0x1014_fd3c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_fd3d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_fd3e, 1); retd(); return;                         /* ret */
        }
    }
}
