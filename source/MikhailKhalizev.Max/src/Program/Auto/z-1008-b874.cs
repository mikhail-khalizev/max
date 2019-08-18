using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bdf96ac9-9a5e-4df1-9e3f-c081ca760899")]
        public void Method_1008_b874()
        {
            ii(0x1008_b874, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_b879, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a4d4); /* call 0x10165d52 */
            ii(0x1008_b87e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b87f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b880, 1); pushd(edx);                             /* push edx */
            ii(0x1008_b881, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b882, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b883, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b884, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b886, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_b88c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_b88f, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_b894, 5); calld(0x1007_6338, -0x1_5561);          /* call 0x10076338 */
            ii(0x1008_b899, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1008_b89c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_b89e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_b8a0, 5); calld(0x1007_64b8, -0x1_53ed);          /* call 0x100764b8 */
            ii(0x1008_b8a5, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_b8ac, 2); jmpd(0x1008_b8b6, 0x8); goto l_0x1008_b8b6; /* jmp 0x1008b8b6 */
        l_0x1008_b8ae:
            ii(0x1008_b8ae, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b8b1, 5); calld(0x1007_6bf8, -0x1_4cbe);          /* call 0x10076bf8 */
        l_0x1008_b8b6:
            ii(0x1008_b8b6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b8b8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b8bb, 5); calld(0x1013_ad71, 0xa_f4b1);           /* call 0x1013ad71 */
            ii(0x1008_b8c0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_b8c2, 2); if(jzd(0x1008_b8f9, 0x35)) goto l_0x1008_b8f9; /* jz 0x1008b8f9 */
            ii(0x1008_b8c4, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b8c7, 5); calld(0x1007_63a0, -0x1_552c);          /* call 0x100763a0 */
            ii(0x1008_b8cc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b8ce, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_b8d1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1008_b8d5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_b8d7, 2); if(jnzd(0x1008_b8f7, 0x1e)) goto l_0x1008_b8f7; /* jnz 0x1008b8f7 */
            ii(0x1008_b8d9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b8dc, 5); calld(0x1007_63a0, -0x1_5541);          /* call 0x100763a0 */
            ii(0x1008_b8e1, 5); cmp(memw_a32[ds, eax + 0x8], 0x7);      /* cmp word [eax+0x8], 0x7 */
            ii(0x1008_b8e6, 2); if(jnzd(0x1008_b8f7, 0xf)) goto l_0x1008_b8f7; /* jnz 0x1008b8f7 */
            ii(0x1008_b8e8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b8eb, 5); calld(0x1007_63a0, -0x1_5550);          /* call 0x100763a0 */
            ii(0x1008_b8f0, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1008_b8f4, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1008_b8f7:
            ii(0x1008_b8f7, 2); jmpd(0x1008_b8ae, -0x4b); goto l_0x1008_b8ae; /* jmp 0x1008b8ae */
        l_0x1008_b8f9:
            ii(0x1008_b8f9, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1008_b8fd, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1008_b900, 2); if(jged(0x1008_b908, 0x6)) goto l_0x1008_b908; /* jge 0x1008b908 */
            ii(0x1008_b902, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
            ii(0x1008_b906, 2); jmpd(0x1008_b90c, 0x4); goto l_0x1008_b90c; /* jmp 0x1008b90c */
        l_0x1008_b908:
            ii(0x1008_b908, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
        l_0x1008_b90c:
            ii(0x1008_b90c, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1008_b90f, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1008_b912, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_b914, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_b917, 5); calld(0x1007_5f6c, -0x1_59b0);          /* call 0x10075f6c */
            ii(0x1008_b91c, 2); jmpd(0x1008_b928, 0xa); goto l_0x1008_b928; /* jmp 0x1008b928 */
        //    ii(0x1008_b91e, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1008_b920, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x1008_b923, 5); calld(0x1007_5f6c, -0x1_59bc);          /* call 0x10075f6c */
        l_0x1008_b928:
            ii(0x1008_b928, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1008_b92b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b92d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b92e, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b92f, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b930, 1); popd(edx);                              /* pop edx */
            ii(0x1008_b931, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b932, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b933, 1); retd(); return;                         /* ret */
        }
    }
}
