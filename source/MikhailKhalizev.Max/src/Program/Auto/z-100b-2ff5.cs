using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_2ff5-9c341897")]
        public void Method_100b_2ff5()
        {
            ii(0x100b_2ff5, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100b_2ffa, 5); calld(Definitions.sys_check_available_stack_size, 0xb_2d53); /* call 0x10165d52 */
            ii(0x100b_2fff, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_3000, 1); pushd(esi);                             /* push esi */
            ii(0x100b_3001, 1); pushd(edi);                             /* push edi */
            ii(0x100b_3002, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_3003, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3005, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_300b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_300e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100b_3011, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100b_3014, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_3018, 2); if(jzd(0x100b_302b, 0x11)) goto l_0x100b_302b; /* jz 0x100b302b */
            ii(0x100b_301a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_301c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_301f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_3022, 5); calld(0x1013_ad71, 0x8_7d4a);           /* call 0x1013ad71 */
            ii(0x100b_3027, 2); test(al, al);                           /* test al, al */
            ii(0x100b_3029, 2); if(jnzd(0x100b_302d, 0x2)) goto l_0x100b_302d; /* jnz 0x100b302d */
        l_0x100b_302b:
            ii(0x100b_302b, 2); jmpd(0x100b_303e, 0x11); goto l_0x100b_303e; /* jmp 0x100b303e */
        l_0x100b_302d:
            ii(0x100b_302d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_3030, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_3033, 5); calld(0x1007_6574, -0x3_cac4);          /* call 0x10076574 */
            ii(0x100b_3038, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x100b_303c, 2); if(jzd(0x100b_3040, 0x2)) goto l_0x100b_3040; /* jz 0x100b3040 */
        l_0x100b_303e:
            ii(0x100b_303e, 2); jmpd(0x100b_3059, 0x19); goto l_0x100b_3059; /* jmp 0x100b3059 */
        l_0x100b_3040:
            ii(0x100b_3040, 5); calld(0x1008_b0e4, -0x2_7f61);          /* call 0x1008b0e4 */
            ii(0x100b_3045, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_3047, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_3049, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_304c, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_304f, 5); calld(0x1007_65d0, -0x3_ca84);          /* call 0x100765d0 */
            ii(0x100b_3054, 5); calld(0x100a_297d, -0x1_06dc);          /* call 0x100a297d */
        l_0x100b_3059:
            ii(0x100b_3059, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_305b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_305c, 1); popd(edi);                              /* pop edi */
            ii(0x100b_305d, 1); popd(esi);                              /* pop esi */
            ii(0x100b_305e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_305f, 1); retd(); return;                         /* ret */
        }
    }
}
