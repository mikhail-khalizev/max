using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_2982-b25965f2")]
        public void Method_100b_2982()
        {
            ii(0x100b_2982, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_2987, 5); calld(Definitions.sys_check_available_stack_size, 0xb_33c6); /* call 0x10165d52 */
            ii(0x100b_298c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_298d, 1); pushd(esi);                             /* push esi */
            ii(0x100b_298e, 1); pushd(edi);                             /* push edi */
            ii(0x100b_298f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_2990, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_2992, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_2998, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_299b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_299e, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_29a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_29a4, 5); calld(0x1015_26ac, 0x9_fd03);           /* call 0x101526ac */
            ii(0x100b_29a9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_29ab, 2); if(jzd(0x100b_29c8, 0x1b)) goto l_0x100b_29c8; /* jz 0x100b29c8 */
            ii(0x100b_29ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_29b0, 5); calld(0x1015_26ac, 0x9_fcf7);           /* call 0x101526ac */
            ii(0x100b_29b5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_29b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_29bb, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_29be, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_29c1, 3); calld_abs(memd_a32[ds, edx + 0x20]);    /* call dword [edx+0x20] */
            ii(0x100b_29c4, 2); cmp(al, 0x17);                          /* cmp al, 0x17 */
            ii(0x100b_29c6, 2); if(jzd(0x100b_29ca, 0x2)) goto l_0x100b_29ca; /* jz 0x100b29ca */
        l_0x100b_29c8:
            ii(0x100b_29c8, 2); jmpd(0x100b_29dc, 0x12); goto l_0x100b_29dc; /* jmp 0x100b29dc */
        l_0x100b_29ca:
            ii(0x100b_29ca, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_29cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_29d2, 5); calld(0x1015_26ac, 0x9_fcd5);           /* call 0x101526ac */
            ii(0x100b_29d7, 5); calld(0x100a_c66b, -0x6371);            /* call 0x100ac66b */
        l_0x100b_29dc:
            ii(0x100b_29dc, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_29e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_29e4, 5); calld(0x100a_297d, -0x1_006c);          /* call 0x100a297d */
            ii(0x100b_29e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_29eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_29ee, 5); calld(0x100a_297d, -0x1_0076);          /* call 0x100a297d */
            ii(0x100b_29f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_29f5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_29f6, 1); popd(edi);                              /* pop edi */
            ii(0x100b_29f7, 1); popd(esi);                              /* pop esi */
            ii(0x100b_29f8, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_29f9, 1); retd();                                 /* ret */
        }
    }
}
