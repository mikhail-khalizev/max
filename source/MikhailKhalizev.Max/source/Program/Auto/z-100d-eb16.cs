using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_eb16-f19a0851")]
        public void Method_100d_eb16()
        {
            ii(0x100d_eb16, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100d_eb1b, 5);  call(Definitions.sys_check_available_stack_size, 0x8_7232);/* call 0x10165d52 */
            ii(0x100d_eb20, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_eb21, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_eb22, 1);  push(edx);                            /* push edx */
            ii(0x100d_eb23, 1);  push(esi);                            /* push esi */
            ii(0x100d_eb24, 1);  push(edi);                            /* push edi */
            ii(0x100d_eb25, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_eb26, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_eb28, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100d_eb2e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100d_eb31, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100d_eb35, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100d_eb3c, 2);  jmp(0x100d_eb44, 6); goto l_0x100d_eb44;/* jmp 0x100deb44 */
        l_0x100d_eb3e:
            ii(0x100d_eb3e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_eb41, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x100d_eb44:
            ii(0x100d_eb44, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_eb47, 5);  add(eax, 0x3b3);                      /* add eax, 0x3b3 */
            ii(0x100d_eb4c, 5);  call(Definitions.my_2_get_count, -0x5_37e9);/* call 0x1008b368 */
            ii(0x100d_eb51, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_eb55, 6);  if(jle(0x100d_ec6b, 0x110)) goto l_0x100d_ec6b;/* jle 0x100dec6b */
            ii(0x100d_eb5b, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_eb5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_eb62, 5);  add(eax, 0x3b3);                      /* add eax, 0x3b3 */
            ii(0x100d_eb67, 5);  call(0x1008_b228, -0x5_3944);         /* call 0x1008b228 */
            ii(0x100d_eb6c, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_eb6f, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_eb72, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_eb75, 6);  add(edx, 0x1cf);                      /* add edx, 0x1cf */
            ii(0x100d_eb7b, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_eb7d, 5);  call(0x1007_6730, -0x6_8452);         /* call 0x10076730 */
            ii(0x100d_eb82, 4);  mov(ax, memw[ds, eax + 25]);          /* mov ax, [eax+0x19] */
            ii(0x100d_eb86, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_eb89, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_eb8d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_eb90, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_eb95, 5);  call(0x100e_08bc, 0x1d22);            /* call 0x100e08bc */
            ii(0x100d_eb9a, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100d_eb9d, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_eba1, 6);  if(jle(0x100d_ec66, 0xbf)) goto l_0x100d_ec66;/* jle 0x100dec66 */
            ii(0x100d_eba7, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100d_ebab, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_ebaf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ebb2, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_ebb7, 5);  call(0x100e_08bc, 0x1d00);            /* call 0x100e08bc */
            ii(0x100d_ebbc, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100d_ebbf, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_ebc3, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100d_ebc5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_ebc7, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_ebcc, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_ebce, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_ebd1, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_ebd3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_ebd5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ebd8, 3);  mov(eax, memd[ds, eax + 77]);         /* mov eax, [eax+0x4d] */
            ii(0x100d_ebdb, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_ebde, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_ebe0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100d_ebe3, 4);  mov(memw[ds, edx + 79], ax);          /* mov [edx+0x4f], ax */
            ii(0x100d_ebe7, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_ebeb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ebee, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_ebf3, 5);  call(0x100e_08bc, 0x1cc4);            /* call 0x100e08bc */
            ii(0x100d_ebf8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100d_ebfa, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_ebfd, 3);  mov(memw[ds, edx], ax);               /* mov [edx], ax */
            ii(0x100d_ec00, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec03, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_ec09, 5);  call(0x100d_5018, -0x9bf6);           /* call 0x100d5018 */
            ii(0x100d_ec0e, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100d_ec12, 2);  if(jnz(0x100d_ec66, 0x52)) goto l_0x100d_ec66;/* jnz 0x100dec66 */
            ii(0x100d_ec14, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100d_ec18, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_ec1d, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_ec1f, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_ec22, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_ec24, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_ec27, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec2a, 6);  mov(eax, memd[ds, eax + 991]);        /* mov eax, [eax+0x3df] */
            ii(0x100d_ec30, 5);  call(0x100d_6f8b, -0x7caa);           /* call 0x100d6f8b */
            ii(0x100d_ec35, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x100d_ec39, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec3c, 5);  add(eax, 0x3b7);                      /* add eax, 0x3b7 */
            ii(0x100d_ec41, 5);  call(0x100e_08bc, 0x1c76);            /* call 0x100e08bc */
            ii(0x100d_ec46, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x100d_ec49, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100d_ec4e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100d_ec50, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_ec53, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100d_ec55, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_ec58, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec5b, 6);  mov(eax, memd[ds, eax + 991]);        /* mov eax, [eax+0x3df] */
            ii(0x100d_ec61, 5);  call(0x100d_6f2d, -0x7d39);           /* call 0x100d6f2d */
        l_0x100d_ec66:
            ii(0x100d_ec66, 5);  jmp(0x100d_eb3e, -0x12d); goto l_0x100d_eb3e;/* jmp 0x100deb3e */
        l_0x100d_ec6b:
            ii(0x100d_ec6b, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100d_ec6f, 2);  if(jz(0x100d_ec94, 0x23)) goto l_0x100d_ec94;/* jz 0x100dec94 */
            ii(0x100d_ec71, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec74, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_ec77, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_ec7a, 3);  mov(ebx, memd[ds, eax + 19]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_ec7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_ec80, 6);  mov(eax, memd[ds, eax + 955]);        /* mov eax, [eax+0x3bb] */
            ii(0x100d_ec86, 5);  call(0x100d_0149, -0xeb42);           /* call 0x100d0149 */
            ii(0x100d_ec8b, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_ec8e, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_ec91, 3);  call_abs(memd[ds, ebx + 24]);         /* call dword [ebx+0x18] */
        l_0x100d_ec94:
            ii(0x100d_ec94, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_ec96, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_ec97, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_ec98, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_ec99, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_ec9a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_ec9b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_ec9c, 1);  ret();                                /* ret */
        }
    }
}
