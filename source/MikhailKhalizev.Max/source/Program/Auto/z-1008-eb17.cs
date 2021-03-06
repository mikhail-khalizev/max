using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_eb17-d16349ed")]
        public void Method_1008_eb17()
        {
            ii(0x1008_eb17, 5);  push(0x50);                           /* push 0x50 */
            ii(0x1008_eb1c, 5);  call(Definitions.sys_check_available_stack_size, 0xd_7231);/* call 0x10165d52 */
            ii(0x1008_eb21, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_eb22, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_eb23, 1);  push(esi);                            /* push esi */
            ii(0x1008_eb24, 1);  push(edi);                            /* push edi */
            ii(0x1008_eb25, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_eb26, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_eb28, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1008_eb2e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_eb31, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_eb34, 5);  mov(eax, 0x101c_8178);                /* mov eax, 0x101c8178 */
            ii(0x1008_eb39, 5);  call(0x1007_6338, -0x1_8806);         /* call 0x10076338 */
            ii(0x1008_eb3e, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1008_eb41, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_eb43, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_eb45, 5);  call(0x1007_64b8, -0x1_8692);         /* call 0x100764b8 */
            ii(0x1008_eb4a, 2);  jmp(0x1008_eb54, 8); goto l_0x1008_eb54;/* jmp 0x1008eb54 */
        l_0x1008_eb4c:
            ii(0x1008_eb4c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eb4f, 5);  call(0x1007_6bf8, -0x1_7f5c);         /* call 0x10076bf8 */
        l_0x1008_eb54:
            ii(0x1008_eb54, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_eb56, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eb59, 5);  call(0x1013_ad71, 0xa_c213);          /* call 0x1013ad71 */
            ii(0x1008_eb5e, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_eb60, 2);  if(jz(0x1008_ebba, 0x58)) goto l_0x1008_ebba;/* jz 0x1008ebba */
            ii(0x1008_eb62, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eb65, 5);  call(0x1007_63a0, -0x1_87ca);         /* call 0x100763a0 */
            ii(0x1008_eb6a, 5);  cmp(memw[ds, eax + 8], 0x27);         /* cmp word [eax+0x8], 0x27 */
            ii(0x1008_eb6f, 2);  if(jnz(0x1008_eb8b, 0x1a)) goto l_0x1008_eb8b;/* jnz 0x1008eb8b */
            ii(0x1008_eb71, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_eb74, 3);  mov(edx, memd[ds, eax + 7]);          /* mov edx, [eax+0x7] */
            ii(0x1008_eb77, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1008_eb7a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eb7d, 5);  call(0x1007_63a0, -0x1_87e2);         /* call 0x100763a0 */
            ii(0x1008_eb82, 5);  call(0x1007_6074, -0x1_8b13);         /* call 0x10076074 */
            ii(0x1008_eb87, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_eb89, 2);  if(jnz(0x1008_eb8d, 2)) goto l_0x1008_eb8d;/* jnz 0x1008eb8d */
        l_0x1008_eb8b:
            ii(0x1008_eb8b, 2);  jmp(0x1008_ebb8, 0x2b); goto l_0x1008_ebb8;/* jmp 0x1008ebb8 */
        l_0x1008_eb8d:
            ii(0x1008_eb8d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eb90, 5);  call(0x1007_63a0, -0x1_87f5);         /* call 0x100763a0 */
            ii(0x1008_eb95, 3);  mov(eax, memd[ds, eax + 24]);         /* mov eax, [eax+0x18] */
            ii(0x1008_eb98, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_eb9b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_eb9e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_eba1, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1008_eba3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_eba6, 5);  call(0x1007_63a0, -0x1_880b);         /* call 0x100763a0 */
            ii(0x1008_ebab, 3);  mov(eax, memd[ds, eax + 26]);         /* mov eax, [eax+0x1a] */
            ii(0x1008_ebae, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1008_ebb1, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x1008_ebb3, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_ebb5, 3);  mov(memb[ds, eax], 2);                /* mov byte [eax], 0x2 */
        l_0x1008_ebb8:
            ii(0x1008_ebb8, 2);  jmp(0x1008_eb4c, -0x6e); goto l_0x1008_eb4c;/* jmp 0x1008eb4c */
        l_0x1008_ebba:
            ii(0x1008_ebba, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1008_ebbf, 5);  call(0x1008_a768, -0x445c);           /* call 0x1008a768 */
            ii(0x1008_ebc4, 3);  lea(ebx, memd[ss, ebp - 28]);         /* lea ebx, [ebp-0x1c] */
            ii(0x1008_ebc7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ebc9, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_ebcb, 5);  call(0x1008_ae70, -0x3d60);           /* call 0x1008ae70 */
            ii(0x1008_ebd0, 2);  jmp(0x1008_ebda, 8); goto l_0x1008_ebda;/* jmp 0x1008ebda */
        l_0x1008_ebd2:
            ii(0x1008_ebd2, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ebd5, 5);  call(0x1007_6bf8, -0x1_7fe2);         /* call 0x10076bf8 */
        l_0x1008_ebda:
            ii(0x1008_ebda, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ebdc, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ebdf, 5);  call(0x1013_ad71, 0xa_c18d);          /* call 0x1013ad71 */
            ii(0x1008_ebe4, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_ebe6, 6);  if(jz(0x1008_ec7f, 0x93)) goto l_0x1008_ec7f;/* jz 0x1008ec7f */
            ii(0x1008_ebec, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ebef, 5);  call(0x1008_adc4, -0x3e30);           /* call 0x1008adc4 */
            ii(0x1008_ebf4, 5);  call(0x1008_ad90, -0x3e69);           /* call 0x1008ad90 */
            ii(0x1008_ebf9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_ebfb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_ebfe, 4);  cmp(dx, memw[ds, eax + 9]);           /* cmp dx, [eax+0x9] */
            ii(0x1008_ec02, 2);  if(jnz(0x1008_ec1f, 0x1b)) goto l_0x1008_ec1f;/* jnz 0x1008ec1f */
            ii(0x1008_ec04, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ec07, 5);  call(0x1008_adc4, -0x3e48);           /* call 0x1008adc4 */
            ii(0x1008_ec0c, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1008_ec0f, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_ec12, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1008_ec15, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1008_ec18, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1008_ec1b, 2);  cmp(al, 9);                           /* cmp al, 0x9 */
            ii(0x1008_ec1d, 2);  if(jz(0x1008_ec21, 2)) goto l_0x1008_ec21;/* jz 0x1008ec21 */
        l_0x1008_ec1f:
            ii(0x1008_ec1f, 2);  jmp(0x1008_ec7a, 0x59); goto l_0x1008_ec7a;/* jmp 0x1008ec7a */
        l_0x1008_ec21:
            ii(0x1008_ec21, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ec24, 5);  call(0x1008_adf8, -0x3e31);           /* call 0x1008adf8 */
            ii(0x1008_ec29, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1008_ec2c, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_ec2f, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1008_ec32, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1008_ec35, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_ec38, 3);  lea(edx, memd[ss, ebp - 56]);         /* lea edx, [ebp-0x38] */
            ii(0x1008_ec3b, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1008_ec3e, 3);  call_abs(memd[ds, ebx + 28]);         /* call dword [ebx+0x1c] */
            ii(0x1008_ec41, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1008_ec44, 5);  call(0x1009_c4c4, 0xd87b);            /* call 0x1009c4c4 */
            ii(0x1008_ec49, 4);  cmp(ax, 0x27);                        /* cmp ax, 0x27 */
            ii(0x1008_ec4d, 2);  if(jnz(0x1008_ec7a, 0x2b)) goto l_0x1008_ec7a;/* jnz 0x1008ec7a */
            ii(0x1008_ec4f, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_ec52, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ec55, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_ec58, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_ec5a, 3);  add(eax, memd[ss, ebp - 52]);         /* add eax, [ebp-0x34] */
            ii(0x1008_ec5d, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_ec5f, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_ec64, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1008_ec67, 2);  if(jnz(0x1008_ec7a, 0x11)) goto l_0x1008_ec7a;/* jnz 0x1008ec7a */
            ii(0x1008_ec69, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1008_ec6c, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ec6f, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_ec72, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_ec74, 3);  add(eax, memd[ss, ebp - 52]);         /* add eax, [ebp-0x34] */
            ii(0x1008_ec77, 3);  mov(memb[ds, eax], 2);                /* mov byte [eax], 0x2 */
        l_0x1008_ec7a:
            ii(0x1008_ec7a, 5);  jmp(0x1008_ebd2, -0xad); goto l_0x1008_ebd2;/* jmp 0x1008ebd2 */
        l_0x1008_ec7f:
            ii(0x1008_ec7f, 5);  mov(eax, memd[ds, 0x101c_811c]);      /* mov eax, [0x101c811c] */
            ii(0x1008_ec84, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1008_ec87, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1008_ec8e, 2);  jmp(0x1008_ec96, 6); goto l_0x1008_ec96;/* jmp 0x1008ec96 */
        l_0x1008_ec90:
            ii(0x1008_ec90, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_ec93, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1008_ec96:
            ii(0x1008_ec96, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_ec99, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1008_eca0, 6);  if(jge(0x1008_ed0f, 0x69)) goto l_0x1008_ed0f;/* jge 0x1008ed0f */
            ii(0x1008_eca6, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1008_ecad, 2);  jmp(0x1008_ecb5, 6); goto l_0x1008_ecb5;/* jmp 0x1008ecb5 */
        l_0x1008_ecaf:
            ii(0x1008_ecaf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ecb2, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1008_ecb5:
            ii(0x1008_ecb5, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_ecb8, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1008_ecbf, 2);  if(jge(0x1008_ed0d, 0x4c)) goto l_0x1008_ed0d;/* jge 0x1008ed0d */
            ii(0x1008_ecc1, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1008_ecc4, 4);  add(memd[ss, ebp - 20], 2);           /* add dword [ebp-0x14], 0x2 */
            ii(0x1008_ecc8, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1008_eccb, 5);  and(eax, 0x1f);                       /* and eax, 0x1f */
            ii(0x1008_ecd0, 4);  cmp(ax, 8);                           /* cmp ax, 0x8 */
            ii(0x1008_ecd4, 2);  if(jb(0x1008_ecf4, 0x1e)) goto l_0x1008_ecf4;/* jb 0x1008ecf4 */
            ii(0x1008_ecd6, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_ecda, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ecdd, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_ece0, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_ece4, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_ece6, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_ece8, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1008_ecea, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1008_ecef, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1008_ecf2, 2);  if(jz(0x1008_ecf6, 2)) goto l_0x1008_ecf6;/* jz 0x1008ecf6 */
        l_0x1008_ecf4:
            ii(0x1008_ecf4, 2);  jmp(0x1008_ed0b, 0x15); goto l_0x1008_ed0b;/* jmp 0x1008ed0b */
        l_0x1008_ecf6:
            ii(0x1008_ecf6, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1008_ecfa, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1008_ecfd, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1008_ed00, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1008_ed04, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_ed06, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1008_ed08, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x1008_ed0b:
            ii(0x1008_ed0b, 2);  jmp(0x1008_ecaf, -0x5e); goto l_0x1008_ecaf;/* jmp 0x1008ecaf */
        l_0x1008_ed0d:
            ii(0x1008_ed0d, 2);  jmp(0x1008_ec90, -0x7f); goto l_0x1008_ec90;/* jmp 0x1008ec90 */
        l_0x1008_ed0f:
            ii(0x1008_ed0f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ed11, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1008_ed14, 5);  call(0x1008_8bbc, -0x615d);           /* call 0x10088bbc */
            ii(0x1008_ed19, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_ed1b, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1008_ed1e, 5);  call(0x1007_5f6c, -0x1_8db7);         /* call 0x10075f6c */
            ii(0x1008_ed23, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_ed25, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_ed26, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_ed27, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_ed28, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_ed29, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_ed2a, 1);  ret();                                /* ret */
        }
    }
}
