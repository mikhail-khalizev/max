using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cbd0-b280f097")]
        public void Method_1007_cbd0()
        {
            ii(0x1007_cbd0, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1007_cbd5, 5);  call(Definitions.sys_check_available_stack_size, 0xe_9178);/* call 0x10165d52 */
            ii(0x1007_cbda, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_cbdb, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_cbdc, 1);  push(edx);                            /* push edx */
            ii(0x1007_cbdd, 1);  push(esi);                            /* push esi */
            ii(0x1007_cbde, 1);  push(edi);                            /* push edi */
            ii(0x1007_cbdf, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_cbe0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_cbe2, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_cbe8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_cbeb, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1007_cbf2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_cbf4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cbf7, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cbfa, 5);  call(0x1013_ad11, 0xb_e112);          /* call 0x1013ad11 */
            ii(0x1007_cbff, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cc01, 2);  if(jz(0x1007_cc0c, 9)) goto l_0x1007_cc0c;/* jz 0x1007cc0c */
            ii(0x1007_cc03, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc06, 4);  cmp(memb[ds, eax + 6], 0);            /* cmp byte [eax+0x6], 0x0 */
            ii(0x1007_cc0a, 2);  if(jnz(0x1007_cc11, 5)) goto l_0x1007_cc11;/* jnz 0x1007cc11 */
        l_0x1007_cc0c:
            ii(0x1007_cc0c, 5);  jmp(0x1007_cc91, 0x80); goto l_0x1007_cc91;/* jmp 0x1007cc91 */
        l_0x1007_cc11:
            ii(0x1007_cc11, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc14, 4);  mov(memb[ds, eax + 6], 0);            /* mov byte [eax+0x6], 0x0 */
            ii(0x1007_cc18, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x1007_cc1d, 5);  call(0x1007_6338, -0x68ea);           /* call 0x10076338 */
            ii(0x1007_cc22, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_cc24, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc27, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cc2a, 5);  call(0x1007_643c, -0x67f3);           /* call 0x1007643c */
            ii(0x1007_cc2f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_cc31, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc34, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cc37, 5);  call(0x1013_ad11, 0xb_e0d5);          /* call 0x1013ad11 */
            ii(0x1007_cc3c, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cc3e, 2);  if(jz(0x1007_cc59, 0x19)) goto l_0x1007_cc59;/* jz 0x1007cc59 */
            ii(0x1007_cc40, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x1007_cc45, 5);  call(0x1007_6338, -0x6912);           /* call 0x10076338 */
            ii(0x1007_cc4a, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_cc4d, 3);  add(ebx, 0x13);                       /* add ebx, 0x13 */
            ii(0x1007_cc50, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_cc52, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_cc54, 5);  call(0x1007_643c, -0x681d);           /* call 0x1007643c */
        l_0x1007_cc59:
            ii(0x1007_cc59, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_cc5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc5e, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cc61, 5);  call(0x1013_ad71, 0xb_e10b);          /* call 0x1013ad71 */
            ii(0x1007_cc66, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cc68, 2);  if(jz(0x1007_cc87, 0x1d)) goto l_0x1007_cc87;/* jz 0x1007cc87 */
            ii(0x1007_cc6a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc6d, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cc70, 5);  call(0x1007_63a0, -0x68d5);           /* call 0x100763a0 */
            ii(0x1007_cc75, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_cc77, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1007_cc7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc7d, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1007_cc80, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_cc83, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_cc85, 2);  if(jnz(0x1007_cc89, 2)) goto l_0x1007_cc89;/* jnz 0x1007cc89 */
        l_0x1007_cc87:
            ii(0x1007_cc87, 2);  jmp(0x1007_cc91, 8); goto l_0x1007_cc91;/* jmp 0x1007cc91 */
        l_0x1007_cc89:
            ii(0x1007_cc89, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc8c, 5);  call(0x1007_ce58, 0x1c7);             /* call 0x1007ce58 */
        l_0x1007_cc91:
            ii(0x1007_cc91, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_cc93, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cc96, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_cc99, 5);  call(0x1013_ad71, 0xb_e0d3);          /* call 0x1013ad71 */
            ii(0x1007_cc9e, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cca0, 6);  if(jz(0x1007_cd38, 0x92)) goto l_0x1007_cd38;/* jz 0x1007cd38 */
            ii(0x1007_cca6, 5);  call(0x1014_82f4, 0xc_b649);          /* call 0x101482f4 */
            ii(0x1007_ccab, 6);  sub(eax, memd[ds, 0x101c_3974]);      /* sub eax, [0x101c3974] */
            ii(0x1007_ccb1, 6);  cmp(eax, memd[ds, 0x101b_dd84]);      /* cmp eax, [0x101bdd84] */
            ii(0x1007_ccb7, 2);  if(jb(0x1007_cd19, 0x60)) goto l_0x1007_cd19;/* jb 0x1007cd19 */
            ii(0x1007_ccb9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_ccbc, 5);  call(0x1008_ad28, 0xe067);            /* call 0x1008ad28 */
            ii(0x1007_ccc1, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_ccc3, 2);  if(jnz(0x1007_cd17, 0x52)) goto l_0x1007_cd17;/* jnz 0x1007cd17 */
            ii(0x1007_ccc5, 5);  call(0x1008_a7bc, 0xdaf2);            /* call 0x1008a7bc */
            ii(0x1007_ccca, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1007_cccf, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_ccd2, 5);  mov(eax, 0xa);                        /* mov eax, 0xa */
            ii(0x1007_ccd7, 5);  call(Definitions.sys_new, 0xe_9124);  /* call 0x10165e00 */
            ii(0x1007_ccdc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_ccdf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_cce2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_cce5, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1007_cce9, 2);  if(jz(0x1007_cd01, 0x16)) goto l_0x1007_cd01;/* jz 0x1007cd01 */
            ii(0x1007_cceb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_ccee, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_ccf1, 5);  call(Definitions.my_ctor_c11, 0x2_6bd3);/* call 0x100a38c9 */
            ii(0x1007_ccf6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1007_ccf9, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_ccfc, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_ccff, 2);  jmp(0x1007_cd07, 6); goto l_0x1007_cd07;/* jmp 0x1007cd07 */
        l_0x1007_cd01:
            ii(0x1007_cd01, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_cd04, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1007_cd07:
            ii(0x1007_cd07, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x1007_cd0a, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_cd0f, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1007_cd12, 5);  call(0x100a_4db6, 0x2_809f);          /* call 0x100a4db6 */
        l_0x1007_cd17:
            ii(0x1007_cd17, 2);  jmp(0x1007_cd38, 0x1f); goto l_0x1007_cd38;/* jmp 0x1007cd38 */
        l_0x1007_cd19:
            ii(0x1007_cd19, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cd1c, 5);  call(0x1007_ce16, 0xf5);              /* call 0x1007ce16 */
            ii(0x1007_cd21, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_cd23, 2);  if(jnz(0x1007_cd38, 0x13)) goto l_0x1007_cd38;/* jnz 0x1007cd38 */
            ii(0x1007_cd25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_cd28, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1007_cd2b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_cd2e, 5);  call(0x1007_ce58, 0x125);             /* call 0x1007ce58 */
            ii(0x1007_cd33, 5);  jmp(0x1007_cc91, -0xa7); goto l_0x1007_cc91;/* jmp 0x1007cc91 */
        l_0x1007_cd38:
            ii(0x1007_cd38, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_cd3a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_cd3b, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_cd3c, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_cd3d, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_cd3e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_cd3f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_cd40, 1);  ret();                                /* ret */
        }
    }
}
