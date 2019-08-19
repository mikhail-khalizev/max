using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_caf8-898669d0")]
        public void Method_100e_caf8()
        {
            ii(0x100e_caf8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_cafd, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9250); /* call 0x10165d52 */
            ii(0x100e_cb02, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_cb03, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_cb04, 1); pushd(edx);                             /* push edx */
            ii(0x100e_cb05, 1); pushd(esi);                             /* push esi */
            ii(0x100e_cb06, 1); pushd(edi);                             /* push edi */
            ii(0x100e_cb07, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_cb08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_cb0a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_cb10, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_cb13, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_cb18, 5); calld(0x1007_6338, -0x7_67e5);          /* call 0x10076338 */
            ii(0x100e_cb1d, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x100e_cb20, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_cb22, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_cb24, 5); calld(0x1007_64b8, -0x7_6671);          /* call 0x100764b8 */
            ii(0x100e_cb29, 2); jmpd(0x100e_cb33, 0x8); goto l_0x100e_cb33; /* jmp 0x100ecb33 */
        l_0x100e_cb2b:
            ii(0x100e_cb2b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb2e, 5); calld(0x1007_6bf8, -0x7_5f3b);          /* call 0x10076bf8 */
        l_0x100e_cb33:
            ii(0x100e_cb33, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cb35, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb38, 5); calld(0x1013_ad71, 0x4_e234);           /* call 0x1013ad71 */
            ii(0x100e_cb3d, 2); test(al, al);                           /* test al, al */
            ii(0x100e_cb3f, 2); if(jzd(0x100e_cb8d, 0x4c)) goto l_0x100e_cb8d; /* jz 0x100ecb8d */
            ii(0x100e_cb41, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb44, 5); calld(0x1007_63a0, -0x7_67a9);          /* call 0x100763a0 */
            ii(0x100e_cb49, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cb4b, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100e_cb4e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_cb52, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_cb54, 2); if(jnzd(0x100e_cb65, 0xf)) goto l_0x100e_cb65; /* jnz 0x100ecb65 */
            ii(0x100e_cb56, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb59, 5); calld(0x1007_63a0, -0x7_67be);          /* call 0x100763a0 */
            ii(0x100e_cb5e, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x100e_cb63, 2); if(jzd(0x100e_cb67, 0x2)) goto l_0x100e_cb67; /* jz 0x100ecb67 */
        l_0x100e_cb65:
            ii(0x100e_cb65, 2); jmpd(0x100e_cb79, 0x12); goto l_0x100e_cb79; /* jmp 0x100ecb79 */
        l_0x100e_cb67:
            ii(0x100e_cb67, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb6a, 5); calld(0x1007_63a0, -0x7_67cf);          /* call 0x100763a0 */
            ii(0x100e_cb6f, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x100e_cb72, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_cb75, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_cb77, 2); if(jgd(0x100e_cb7b, 0x2)) goto l_0x100e_cb7b; /* jg 0x100ecb7b */
        l_0x100e_cb79:
            ii(0x100e_cb79, 2); jmpd(0x100e_cb8b, 0x10); goto l_0x100e_cb8b; /* jmp 0x100ecb8b */
        l_0x100e_cb7b:
            ii(0x100e_cb7b, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100e_cb7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cb81, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb84, 5); calld(0x1007_5f6c, -0x7_6c1d);          /* call 0x10075f6c */
            ii(0x100e_cb89, 2); jmpd(0x100e_cba7, 0x1c); goto l_0x100e_cba7; /* jmp 0x100ecba7 */
        l_0x100e_cb8b:
            ii(0x100e_cb8b, 2); jmpd(0x100e_cb2b, -0x62); goto l_0x100e_cb2b; /* jmp 0x100ecb2b */
        l_0x100e_cb8d:
            ii(0x100e_cb8d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100e_cb91, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_cb93, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100e_cb96, 5); calld(0x1007_5f6c, -0x7_6c2f);          /* call 0x10075f6c */
            ii(0x100e_cb9b, 2); jmpd(0x100e_cba7, 0xa); goto l_0x100e_cba7; /* jmp 0x100ecba7 */
        //  ii(0x100e_cb9d, 10); Недостижимый код.
        l_0x100e_cba7:
            ii(0x100e_cba7, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_cbaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_cbac, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_cbad, 1); popd(edi);                              /* pop edi */
            ii(0x100e_cbae, 1); popd(esi);                              /* pop esi */
            ii(0x100e_cbaf, 1); popd(edx);                              /* pop edx */
            ii(0x100e_cbb0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_cbb1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_cbb2, 1); retd(); return;                         /* ret */
        }
    }
}
