using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_1a26-1d217099")]
        public void Method_1010_1a26()
        {
            ii(0x1010_1a26, 5);  push(0x5c);                           /* push 0x5c */
            ii(0x1010_1a2b, 5);  call(Definitions.sys_check_available_stack_size, 0x6_4322);/* call 0x10165d52 */
            ii(0x1010_1a30, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_1a31, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_1a32, 1);  push(esi);                            /* push esi */
            ii(0x1010_1a33, 1);  push(edi);                            /* push edi */
            ii(0x1010_1a34, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_1a35, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_1a37, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x1010_1a3d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_1a40, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_1a43, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1a47, 3);  imul(eax, eax, 0x13);                 /* imul eax, eax, 0x13 */
            ii(0x1010_1a4a, 5);  mov(edx, 0x101c_35b4);                /* mov edx, 0x101c35b4 */
            ii(0x1010_1a4f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_1a51, 3);  mov(memd[ss, ebp - 48], edx);         /* mov [ebp-0x30], edx */
            ii(0x1010_1a54, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1010_1a57, 5);  call(Definitions.my_ctor_0x101b_4184, -0x8_af6c);/* call 0x10076af0 */
            ii(0x1010_1a5c, 5);  mov(eax, 0x1d);                       /* mov eax, 0x1d */
            ii(0x1010_1a61, 5);  call(0x1007_5fdc, -0x8_ba8a);         /* call 0x10075fdc */
            ii(0x1010_1a66, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_1a69, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_1a6d, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1010_1a70, 3);  lea(edx, memd[ds, eax + 10]);         /* lea edx, [eax+0xa] */
            ii(0x1010_1a73, 5);  mov(ebx, 0x14);                       /* mov ebx, 0x14 */
            ii(0x1010_1a78, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_1a7a, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_1a7d, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1010_1a7f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_1a82, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1010_1a86, 3);  shl(edx, 3);                          /* shl edx, 0x3 */
            ii(0x1010_1a89, 3);  add(edx, 0xa);                        /* add edx, 0xa */
            ii(0x1010_1a8c, 5);  mov(ebx, 0x14);                       /* mov ebx, 0x14 */
            ii(0x1010_1a91, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1010_1a93, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1010_1a96, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1010_1a98, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_1a9b, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_1a9e, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_1aa2, 4);  mov(memw[ss, ebp - 52], ax);          /* mov [ebp-0x34], ax */
            ii(0x1010_1aa6, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_1aa9, 4);  mov(ax, memw[ds, eax + 10]);          /* mov ax, [eax+0xa] */
            ii(0x1010_1aad, 4);  mov(memw[ss, ebp - 50], ax);          /* mov [ebp-0x32], ax */
            ii(0x1010_1ab1, 4);  movsx(edx, memw[ss, ebp - 50]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1010_1ab5, 4);  movsx(eax, memw[ss, ebp - 52]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1010_1ab9, 5);  call(0x100f_7ed6, -0x9be8);           /* call 0x100f7ed6 */
            ii(0x1010_1abe, 2);  test(al, al);                         /* test al, al */
            ii(0x1010_1ac0, 2);  if(jz(0x1010_1b0e, 0x4c)) goto l_0x1010_1b0e;/* jz 0x10101b0e */
            ii(0x1010_1ac2, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1ac6, 1);  push(eax);                            /* push eax */
            ii(0x1010_1ac7, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1010_1acc, 1);  push(eax);                            /* push eax */
            ii(0x1010_1acd, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1010_1ad0, 1);  push(eax);                            /* push eax */
            ii(0x1010_1ad1, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1010_1ad4, 1);  push(eax);                            /* push eax */
            ii(0x1010_1ad5, 3);  lea(ecx, memd[ss, ebp - 36]);         /* lea ecx, [ebp-0x24] */
            ii(0x1010_1ad8, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1010_1add, 4);  movsx(edx, memw[ss, ebp - 50]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1010_1ae1, 4);  movsx(eax, memw[ss, ebp - 52]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1010_1ae5, 5);  call(0x1014_2d0b, 0x4_1221);          /* call 0x10142d0b */
            ii(0x1010_1aea, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_1aed, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1010_1af1, 2);  if(jl(0x1010_1afc, 9)) goto l_0x1010_1afc;/* jl 0x10101afc */
            ii(0x1010_1af3, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_1af6, 4);  cmp(ax, memw[ss, ebp - 32]);          /* cmp ax, [ebp-0x20] */
            ii(0x1010_1afa, 2);  if(jge(0x1010_1afe, 2)) goto l_0x1010_1afe;/* jge 0x10101afe */
        l_0x1010_1afc:
            ii(0x1010_1afc, 2);  jmp(0x1010_1b0e, 0x10); goto l_0x1010_1b0e;/* jmp 0x10101b0e */
        l_0x1010_1afe:
            ii(0x1010_1afe, 3);  lea(edx, memd[ss, ebp - 52]);         /* lea edx, [ebp-0x34] */
            ii(0x1010_1b01, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1b04, 5);  call(0x1007_5e64, -0x8_bca5);         /* call 0x10075e64 */
            ii(0x1010_1b09, 5);  jmp(0x1010_1c0b, 0xfd); goto l_0x1010_1c0b;/* jmp 0x10101c0b */
        l_0x1010_1b0e:
            ii(0x1010_1b0e, 7);  mov(memd[ss, ebp - 28], 1);           /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1010_1b15, 2);  jmp(0x1010_1b1d, 6); goto l_0x1010_1b1d;/* jmp 0x10101b1d */
        l_0x1010_1b17:
            ii(0x1010_1b17, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_1b1a, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x1010_1b1d:
            ii(0x1010_1b1d, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_1b21, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1010_1b24, 6);  if(jge(0x1010_1c00, 0xd6)) goto l_0x1010_1c00;/* jge 0x10101c00 */
            ii(0x1010_1b2a, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_1b2d, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1010_1b31, 3);  sub(eax, memd[ss, ebp - 28]);         /* sub eax, [ebp-0x1c] */
            ii(0x1010_1b34, 4);  mov(memw[ss, ebp - 52], ax);          /* mov [ebp-0x34], ax */
            ii(0x1010_1b38, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1010_1b3b, 4);  mov(ax, memw[ds, eax + 10]);          /* mov ax, [eax+0xa] */
            ii(0x1010_1b3f, 3);  add(eax, memd[ss, ebp - 28]);         /* add eax, [ebp-0x1c] */
            ii(0x1010_1b42, 4);  mov(memw[ss, ebp - 50], ax);          /* mov [ebp-0x32], ax */
            ii(0x1010_1b46, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1010_1b4d, 2);  jmp(0x1010_1b53, 4); goto l_0x1010_1b53;/* jmp 0x10101b53 */
        l_0x1010_1b4f:
            ii(0x1010_1b4f, 4);  add(memd[ss, ebp - 24], 2);           /* add dword [ebp-0x18], 0x2 */
        l_0x1010_1b53:
            ii(0x1010_1b53, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1010_1b57, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1010_1b5a, 6);  if(jge(0x1010_1bfb, 0x9b)) goto l_0x1010_1bfb;/* jge 0x10101bfb */
            ii(0x1010_1b60, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_1b67, 2);  jmp(0x1010_1b6f, 6); goto l_0x1010_1b6f;/* jmp 0x10101b6f */
        l_0x1010_1b69:
            ii(0x1010_1b69, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_1b6c, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1010_1b6f:
            ii(0x1010_1b6f, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_1b73, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1010_1b75, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1010_1b79, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1010_1b7b, 6);  if(jge(0x1010_1bf6, 0x75)) goto l_0x1010_1bf6;/* jge 0x10101bf6 */
            ii(0x1010_1b81, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1010_1b85, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1010_1b88, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1010_1b8d, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1010_1b8f, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x1010_1b92, 5);  call(0x1008_b1a4, -0x7_69f3);         /* call 0x1008b1a4 */
            ii(0x1010_1b97, 4);  movsx(edx, memw[ss, ebp - 50]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1010_1b9b, 4);  movsx(eax, memw[ss, ebp - 52]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1010_1b9f, 5);  call(0x100f_7ed6, -0x9cce);           /* call 0x100f7ed6 */
            ii(0x1010_1ba4, 2);  test(al, al);                         /* test al, al */
            ii(0x1010_1ba6, 2);  if(jz(0x1010_1bf1, 0x49)) goto l_0x1010_1bf1;/* jz 0x10101bf1 */
            ii(0x1010_1ba8, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_1bac, 1);  push(eax);                            /* push eax */
            ii(0x1010_1bad, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1010_1bb2, 1);  push(eax);                            /* push eax */
            ii(0x1010_1bb3, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1010_1bb6, 1);  push(eax);                            /* push eax */
            ii(0x1010_1bb7, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1010_1bba, 1);  push(eax);                            /* push eax */
            ii(0x1010_1bbb, 3);  lea(ecx, memd[ss, ebp - 36]);         /* lea ecx, [ebp-0x24] */
            ii(0x1010_1bbe, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1010_1bc3, 4);  movsx(edx, memw[ss, ebp - 50]);       /* movsx edx, word [ebp-0x32] */
            ii(0x1010_1bc7, 4);  movsx(eax, memw[ss, ebp - 52]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1010_1bcb, 5);  call(0x1014_2d0b, 0x4_113b);          /* call 0x10142d0b */
            ii(0x1010_1bd0, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x1010_1bd4, 3);  cmp(eax, 0xc);                        /* cmp eax, 0xc */
            ii(0x1010_1bd7, 2);  if(jl(0x1010_1be2, 9)) goto l_0x1010_1be2;/* jl 0x10101be2 */
            ii(0x1010_1bd9, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1010_1bdd, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1010_1be0, 2);  if(jge(0x1010_1be4, 2)) goto l_0x1010_1be4;/* jge 0x10101be4 */
        l_0x1010_1be2:
            ii(0x1010_1be2, 2);  jmp(0x1010_1bf1, 0xd); goto l_0x1010_1bf1;/* jmp 0x10101bf1 */
        l_0x1010_1be4:
            ii(0x1010_1be4, 3);  lea(edx, memd[ss, ebp - 52]);         /* lea edx, [ebp-0x34] */
            ii(0x1010_1be7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1bea, 5);  call(0x1007_5e64, -0x8_bd8b);         /* call 0x10075e64 */
            ii(0x1010_1bef, 2);  jmp(0x1010_1c0b, 0x1a); goto l_0x1010_1c0b;/* jmp 0x10101c0b */
        l_0x1010_1bf1:
            ii(0x1010_1bf1, 5);  jmp(0x1010_1b69, -0x8d); goto l_0x1010_1b69;/* jmp 0x10101b69 */
        l_0x1010_1bf6:
            ii(0x1010_1bf6, 5);  jmp(0x1010_1b4f, -0xac); goto l_0x1010_1b4f;/* jmp 0x10101b4f */
        l_0x1010_1bfb:
            ii(0x1010_1bfb, 5);  jmp(0x1010_1b17, -0xe9); goto l_0x1010_1b17;/* jmp 0x10101b17 */
        l_0x1010_1c00:
            ii(0x1010_1c00, 3);  lea(edx, memd[ss, ebp - 52]);         /* lea edx, [ebp-0x34] */
            ii(0x1010_1c03, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c06, 5);  call(0x1007_5e64, -0x8_bda7);         /* call 0x10075e64 */
        l_0x1010_1c0b:
            ii(0x1010_1c0b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_1c0e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_1c10, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_1c11, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_1c12, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_1c13, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_1c14, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_1c15, 1);  ret();                                /* ret */
        }
    }
}
