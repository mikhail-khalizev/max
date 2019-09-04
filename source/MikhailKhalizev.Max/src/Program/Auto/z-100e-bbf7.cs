using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_bbf7-8290f53a")]
        public void Method_100e_bbf7()
        {
            ii(0x100e_bbf7, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100e_bbfc, 5); call(Definitions.sys_check_available_stack_size, 0x7_a151); /* call 0x10165d52 */
            ii(0x100e_bc01, 1); push(ebx);                              /* push ebx */
            ii(0x100e_bc02, 1); push(ecx);                              /* push ecx */
            ii(0x100e_bc03, 1); push(esi);                              /* push esi */
            ii(0x100e_bc04, 1); push(edi);                              /* push edi */
            ii(0x100e_bc05, 1); push(ebp);                              /* push ebp */
            ii(0x100e_bc06, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_bc08, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100e_bc0e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_bc11, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100e_bc14, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x100e_bc1b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_bc20, 5); call(0x1007_6338, -0x7_58ed);           /* call 0x10076338 */
            ii(0x100e_bc25, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x100e_bc28, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_bc2a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_bc2c, 5); call(0x1007_64b8, -0x7_5779);           /* call 0x100764b8 */
            ii(0x100e_bc31, 2); jmp(0x100e_bc3b, 8); goto l_0x100e_bc3b; /* jmp 0x100ebc3b */
        l_0x100e_bc33:
            ii(0x100e_bc33, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bc36, 5); call(0x1007_6bf8, -0x7_5043);           /* call 0x10076bf8 */
        l_0x100e_bc3b:
            ii(0x100e_bc3b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bc3d, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bc40, 5); call(0x1013_ad71, 0x4_f12c);            /* call 0x1013ad71 */
            ii(0x100e_bc45, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bc47, 2); if(jz(0x100e_bc8d, 0x44)) goto l_0x100e_bc8d; /* jz 0x100ebc8d */
            ii(0x100e_bc49, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bc4c, 5); call(0x1007_63a0, -0x7_58b1);           /* call 0x100763a0 */
            ii(0x100e_bc51, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bc53, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100e_bc56, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_bc5a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_bc5c, 2); if(jnz(0x100e_bc7a, 0x1c)) goto l_0x100e_bc7a; /* jnz 0x100ebc7a */
            ii(0x100e_bc5e, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bc61, 5); call(0x1007_63a0, -0x7_58c6);           /* call 0x100763a0 */
            ii(0x100e_bc66, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100e_bc69, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_bc6c, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_bc6f, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x100e_bc75, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x100e_bc78, 2); if(jz(0x100e_bc7c, 2)) goto l_0x100e_bc7c; /* jz 0x100ebc7c */
        l_0x100e_bc7a:
            ii(0x100e_bc7a, 2); jmp(0x100e_bc8b, 0xf); goto l_0x100e_bc8b; /* jmp 0x100ebc8b */
        l_0x100e_bc7c:
            ii(0x100e_bc7c, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bc7f, 5); call(0x1007_63a0, -0x7_58e4);           /* call 0x100763a0 */
            ii(0x100e_bc84, 4); mov(ax, memw[ds, eax + 82]);            /* mov ax, [eax+0x52] */
            ii(0x100e_bc88, 3); add(memd[ss, ebp - 12], eax);           /* add [ebp-0xc], eax */
        l_0x100e_bc8b:
            ii(0x100e_bc8b, 2); jmp(0x100e_bc33, -0x5a); goto l_0x100e_bc33; /* jmp 0x100ebc33 */
        l_0x100e_bc8d:
            ii(0x100e_bc8d, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_bc92, 5); call(0x1007_6338, -0x7_595f);           /* call 0x10076338 */
            ii(0x100e_bc97, 3); lea(ebx, memd[ss, ebp - 16]);           /* lea ebx, [ebp-0x10] */
            ii(0x100e_bc9a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_bc9c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100e_bc9e, 5); call(0x1007_643c, -0x7_5867);           /* call 0x1007643c */
            ii(0x100e_bca3, 2); jmp(0x100e_bcad, 8); goto l_0x100e_bcad; /* jmp 0x100ebcad */
        l_0x100e_bca5:
            ii(0x100e_bca5, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bca8, 5); call(0x1007_6bf8, -0x7_50b5);           /* call 0x10076bf8 */
        l_0x100e_bcad:
            ii(0x100e_bcad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bcaf, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bcb2, 5); call(0x1013_ad71, 0x4_f0ba);            /* call 0x1013ad71 */
            ii(0x100e_bcb7, 2); test(al, al);                           /* test al, al */
            ii(0x100e_bcb9, 2); if(jz(0x100e_bcff, 0x44)) goto l_0x100e_bcff; /* jz 0x100ebcff */
            ii(0x100e_bcbb, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bcbe, 5); call(0x1007_63a0, -0x7_5923);           /* call 0x100763a0 */
            ii(0x100e_bcc3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bcc5, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x100e_bcc8, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100e_bccc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100e_bcce, 2); if(jnz(0x100e_bcec, 0x1c)) goto l_0x100e_bcec; /* jnz 0x100ebcec */
            ii(0x100e_bcd0, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bcd3, 5); call(0x1007_63a0, -0x7_5938);           /* call 0x100763a0 */
            ii(0x100e_bcd8, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100e_bcdb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_bcde, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100e_bce1, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x100e_bce7, 3); cmp(al, memb[ss, ebp - 4]);             /* cmp al, [ebp-0x4] */
            ii(0x100e_bcea, 2); if(jz(0x100e_bcee, 2)) goto l_0x100e_bcee; /* jz 0x100ebcee */
        l_0x100e_bcec:
            ii(0x100e_bcec, 2); jmp(0x100e_bcfd, 0xf); goto l_0x100e_bcfd; /* jmp 0x100ebcfd */
        l_0x100e_bcee:
            ii(0x100e_bcee, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bcf1, 5); call(0x1007_63a0, -0x7_5956);           /* call 0x100763a0 */
            ii(0x100e_bcf6, 4); mov(ax, memw[ds, eax + 82]);            /* mov ax, [eax+0x52] */
            ii(0x100e_bcfa, 3); add(memd[ss, ebp - 12], eax);           /* add [ebp-0xc], eax */
        l_0x100e_bcfd:
            ii(0x100e_bcfd, 2); jmp(0x100e_bca5, -0x5a); goto l_0x100e_bca5; /* jmp 0x100ebca5 */
        l_0x100e_bcff:
            ii(0x100e_bcff, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_bd02, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100e_bd05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_bd07, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
            ii(0x100e_bd0a, 5); call(0x1007_5f6c, -0x7_5da3);           /* call 0x10075f6c */
            ii(0x100e_bd0f, 2); jmp(0x100e_bd1b, 0xa); goto l_0x100e_bd1b; /* jmp 0x100ebd1b */
        //  ii(0x100e_bd11, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100e_bd13, 3); lea(eax, memd[ss, ebp - 16]);           /* lea eax, [ebp-0x10] */
        //  ii(0x100e_bd16, 5); call(0x1007_5f6c, -0x7_5daf);           /* call 0x10075f6c */
        l_0x100e_bd1b:
            ii(0x100e_bd1b, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100e_bd1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_bd20, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_bd21, 1); pop(edi);                               /* pop edi */
            ii(0x100e_bd22, 1); pop(esi);                               /* pop esi */
            ii(0x100e_bd23, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_bd24, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_bd25, 1); ret();                                  /* ret */
        }
    }
}
