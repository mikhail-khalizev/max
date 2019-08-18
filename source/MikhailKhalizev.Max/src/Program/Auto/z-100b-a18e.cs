using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6057844a-22a6-46b3-8bf3-331eeaaaa70e")]
        public void Method_100b_a18e()
        {
            ii(0x100b_a18e, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100b_a193, 5); calld(Definitions.sys_check_available_stack_size, 0xa_bbba); /* call 0x10165d52 */
            ii(0x100b_a198, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_a199, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a19a, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a19b, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a19c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a19d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a19f, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_a1a5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_a1a8, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_a1ab, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x100b_a1b0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a1b3, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_a1b6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_a1b9, 5); calld(0x1007_49d4, -0x4_57ea);          /* call 0x100749d4 */
            ii(0x100b_a1be, 2); test(al, al);                           /* test al, al */
            ii(0x100b_a1c0, 2); if(jzd(0x100b_a1d2, 0x10)) goto l_0x100b_a1d2; /* jz 0x100ba1d2 */
            ii(0x100b_a1c2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_a1c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_a1c8, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x100b_a1cb, 5); calld(0x1008_ab1c, -0x2_f6b4);          /* call 0x1008ab1c */
            ii(0x100b_a1d0, 2); jmpd(0x100b_a1e0, 0xe); goto l_0x100b_a1e0; /* jmp 0x100ba1e0 */
        l_0x100b_a1d2:
            ii(0x100b_a1d2, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_a1d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_a1d8, 3); add(eax, 0x57);                         /* add eax, 0x57 */
            ii(0x100b_a1db, 5); calld(0x1008_ab1c, -0x2_f6c4);          /* call 0x1008ab1c */
        l_0x100b_a1e0:
            ii(0x100b_a1e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a1e3, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100b_a1e6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_a1eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_a1ed, 2); if(jled(0x100b_a1f8, 0x9)) goto l_0x100b_a1f8; /* jle 0x100ba1f8 */
            ii(0x100b_a1ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_a1f2, 4); cmp(memb_a32[ds, eax + 0xe], 0);        /* cmp byte [eax+0xe], 0x0 */
            ii(0x100b_a1f6, 2); if(jzd(0x100b_a1fa, 0x2)) goto l_0x100b_a1fa; /* jz 0x100ba1fa */
        l_0x100b_a1f8:
            ii(0x100b_a1f8, 2); jmpd(0x100b_a246, 0x4c); goto l_0x100b_a246; /* jmp 0x100ba246 */
        l_0x100b_a1fa:
            ii(0x100b_a1fa, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100b_a201, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100b_a206, 5); calld(Definitions.sys_new, 0xa_bbf5);   /* call 0x10165e00 */
            ii(0x100b_a20b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_a20e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_a211, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_a214, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100b_a218, 2); if(jzd(0x100b_a230, 0x16)) goto l_0x100b_a230; /* jz 0x100ba230 */
            ii(0x100b_a21a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_a21d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_a220, 5); calld(0x100a_3d3a, -0x1_64eb);          /* call 0x100a3d3a */
            ii(0x100b_a225, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_a228, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_a22b, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_a22e, 2); jmpd(0x100b_a236, 0x6); goto l_0x100b_a236; /* jmp 0x100ba236 */
        l_0x100b_a230:
            ii(0x100b_a230, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_a233, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100b_a236:
            ii(0x100b_a236, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100b_a239, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_a23e, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x100b_a241, 5); calld(0x100a_4db6, -0x1_5490);          /* call 0x100a4db6 */
        l_0x100b_a246:
            ii(0x100b_a246, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a248, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a249, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a24a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a24b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a24c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a24d, 1); retd(); return;                         /* ret */
        }
    }
}
