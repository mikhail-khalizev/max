using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f7d31d8-7b5e-4bee-a4dd-b9074baa8baf")]
        public void Method_1007_e6bc()
        {
            ii(0x1007_e6bc, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_e6c1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_768c); /* call 0x10165d52 */
            ii(0x1007_e6c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_e6c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_e6c8, 1); pushd(edx);                             /* push edx */
            ii(0x1007_e6c9, 1); pushd(esi);                             /* push esi */
            ii(0x1007_e6ca, 1); pushd(edi);                             /* push edi */
            ii(0x1007_e6cb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_e6cc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e6ce, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_e6d4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_e6d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_e6da, 5); calld(0x1008_ad28, 0xc649);             /* call 0x1008ad28 */
            ii(0x1007_e6df, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e6e1, 2); if(jnzd(0x1007_e735, 0x52)) goto l_0x1007_e735; /* jnz 0x1007e735 */
            ii(0x1007_e6e3, 5); calld(0x1008_a7bc, 0xc0d4);             /* call 0x1008a7bc */
            ii(0x1007_e6e8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_e6ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_e6f0, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_e6f5, 5); calld(Definitions.sys_new, 0xe_7706);   /* call 0x10165e00 */
            ii(0x1007_e6fa, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_e6fd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e700, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_e703, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1007_e707, 2); if(jzd(0x1007_e71f, 0x16)) goto l_0x1007_e71f; /* jz 0x1007e71f */
            ii(0x1007_e709, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_e70c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e70f, 5); calld(Definitions.my_ctor_c11, 0x2_51b5); /* call 0x100a38c9 */
            ii(0x1007_e714, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_e717, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_e71a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_e71d, 2); jmpd(0x1007_e725, 0x6); goto l_0x1007_e725; /* jmp 0x1007e725 */
        l_0x1007_e71f:
            ii(0x1007_e71f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_e722, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1007_e725:
            ii(0x1007_e725, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x1007_e728, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_e72d, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1007_e730, 5); calld(0x100a_4db6, 0x2_6681);           /* call 0x100a4db6 */
        l_0x1007_e735:
            ii(0x1007_e735, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e737, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e738, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e739, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e73a, 1); popd(edx);                              /* pop edx */
            ii(0x1007_e73b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e73c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_e73d, 1); retd(); return;                         /* ret */
        }
    }
}
