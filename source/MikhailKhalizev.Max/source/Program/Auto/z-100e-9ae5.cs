using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9ae5-a0805711")]
        public void Method_100e_9ae5()
        {
            ii(0x100e_9ae5, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100e_9aea, 5);  call(Definitions.sys_check_available_stack_size, 0x7_c263);/* call 0x10165d52 */
            ii(0x100e_9aef, 1);  push(esi);                            /* push esi */
            ii(0x100e_9af0, 1);  push(edi);                            /* push edi */
            ii(0x100e_9af1, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_9af2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_9af4, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x100e_9afa, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_9afd, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_9b00, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x100e_9b03, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100e_9b06, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x100e_9b0c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_9b0f, 7);  test(memd[ss, ebp + 28], 0x1_0000);   /* test dword [ebp+0x1c], 0x10000 */
            ii(0x100e_9b16, 2);  if(jz(0x100e_9b1e, 6)) goto l_0x100e_9b1e;/* jz 0x100e9b1e */
            ii(0x100e_9b18, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100e_9b1b, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x100e_9b1e:
            ii(0x100e_9b1e, 4);  movsx(edx, memw[ss, ebp + 24]);       /* movsx edx, word [ebp+0x18] */
            ii(0x100e_9b22, 4);  movsx(ebx, memw[ss, ebp - 20]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100e_9b26, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_9b28, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_9b2b, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x100e_9b2d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_9b30, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100e_9b34, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_9b36, 2);  if(jz(0x100e_9b3e, 6)) goto l_0x100e_9b3e;/* jz 0x100e9b3e */
            ii(0x100e_9b38, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100e_9b3c, 2);  if(jnz(0x100e_9b43, 5)) goto l_0x100e_9b43;/* jnz 0x100e9b43 */
        l_0x100e_9b3e:
            ii(0x100e_9b3e, 5);  jmp(0x100e_9c60, 0x11d); goto l_0x100e_9c60;/* jmp 0x100e9c60 */
        l_0x100e_9b43:
            ii(0x100e_9b43, 3);  lea(ecx, memd[ss, ebp - 28]);         /* lea ecx, [ebp-0x1c] */
            ii(0x100e_9b46, 4);  movsx(ebx, memw[ss, ebp + 20]);       /* movsx ebx, word [ebp+0x14] */
            ii(0x100e_9b4a, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100e_9b4e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_9b51, 5);  call(0x100e_969d, -0x4b9);            /* call 0x100e969d */
            ii(0x100e_9b56, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100e_9b59, 4);  cmp(memb[ss, ebp + 36], 0);           /* cmp byte [ebp+0x24], 0x0 */
            ii(0x100e_9b5d, 2);  if(jz(0x100e_9b83, 0x24)) goto l_0x100e_9b83;/* jz 0x100e9b83 */
            ii(0x100e_9b5f, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100e_9b63, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_9b67, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100e_9b6a, 4);  movsx(edx, memw[ss, ebp + 24]);       /* movsx edx, word [ebp+0x18] */
            ii(0x100e_9b6e, 1);  inc(edx);                             /* inc edx */
            ii(0x100e_9b6f, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100e_9b71, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_9b73, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_9b76, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_9b78, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_9b7a, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100e_9b7e, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100e_9b80, 3);  mov(memd[ss, ebp + 16], edx);         /* mov [ebp+0x10], edx */
        l_0x100e_9b83:
            ii(0x100e_9b83, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_9b86, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100e_9b89, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100e_9b90, 2);  jmp(0x100e_9b98, 6); goto l_0x100e_9b98;/* jmp 0x100e9b98 */
        l_0x100e_9b92:
            ii(0x100e_9b92, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_9b95, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x100e_9b98:
            ii(0x100e_9b98, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_9b9b, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x100e_9b9f, 6);  if(jge(0x100e_9c48, 0xa3)) goto l_0x100e_9c48;/* jge 0x100e9c48 */
            ii(0x100e_9ba5, 4);  cmp(memb[ss, ebp + 32], 0);           /* cmp byte [ebp+0x20], 0x0 */
            ii(0x100e_9ba9, 2);  if(jnz(0x100e_9bb4, 9)) goto l_0x100e_9bb4;/* jnz 0x100e9bb4 */
            ii(0x100e_9bab, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x100e_9bb2, 2);  jmp(0x100e_9bf3, 0x3f); goto l_0x100e_9bf3;/* jmp 0x100e9bf3 */
        l_0x100e_9bb4:
            ii(0x100e_9bb4, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_9bb8, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_9bbb, 3);  add(eax, memd[ss, ebp - 32]);         /* add eax, [ebp-0x20] */
            ii(0x100e_9bbe, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_03fb);/* call 0x100897c8 */
            ii(0x100e_9bc3, 6);  call_abs(memd[ds, 0x101b_ddf4]);      /* call dword [0x101bddf4] */
            ii(0x100e_9bc9, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100e_9bcc, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100e_9bcf, 4);  cmp(ax, memw[ss, ebp + 20]);          /* cmp ax, [ebp+0x14] */
            ii(0x100e_9bd3, 2);  if(jle(0x100e_9bdb, 6)) goto l_0x100e_9bdb;/* jle 0x100e9bdb */
            ii(0x100e_9bd5, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100e_9bd8, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x100e_9bdb:
            ii(0x100e_9bdb, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100e_9bdf, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100e_9be3, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_9be5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_9be7, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x100e_9be9, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100e_9bec, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x100e_9bee, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x100e_9bf0, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
        l_0x100e_9bf3:
            ii(0x100e_9bf3, 3);  mov(eax, memd[ss, ebp + 28]);         /* mov eax, [ebp+0x1c] */
            ii(0x100e_9bf6, 1);  push(eax);                            /* push eax */
            ii(0x100e_9bf7, 4);  movsx(ecx, memw[ss, ebp - 8]);        /* movsx ecx, word [ebp-0x8] */
            ii(0x100e_9bfb, 4);  movsx(ebx, memw[ss, ebp + 20]);       /* movsx ebx, word [ebp+0x14] */
            ii(0x100e_9bff, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100e_9c03, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100e_9c06, 3);  add(eax, memd[ss, ebp - 32]);         /* add eax, [ebp-0x20] */
            ii(0x100e_9c09, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_0446);/* call 0x100897c8 */
            ii(0x100e_9c0e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_9c10, 4);  movsx(esi, memw[ss, ebp - 28]);       /* movsx esi, word [ebp-0x1c] */
            ii(0x100e_9c14, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_9c18, 3);  imul(eax, esi);                       /* imul eax, esi */
            ii(0x100e_9c1b, 4);  movsx(esi, memw[ss, ebp + 16]);       /* movsx esi, word [ebp+0x10] */
            ii(0x100e_9c1f, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x100e_9c21, 4);  movsx(esi, memw[ss, ebp - 8]);        /* movsx esi, word [ebp-0x8] */
            ii(0x100e_9c25, 3);  imul(eax, esi);                       /* imul eax, esi */
            ii(0x100e_9c28, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100e_9c2b, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_9c2f, 3);  mov(esi, memd[ss, ebp - 16]);         /* mov esi, [ebp-0x10] */
            ii(0x100e_9c32, 2);  add(esi, eax);                        /* add esi, eax */
            ii(0x100e_9c34, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100e_9c38, 2);  add(eax, esi);                        /* add eax, esi */
            ii(0x100e_9c3a, 3);  add(eax, memd[ss, ebp - 40]);         /* add eax, [ebp-0x28] */
            ii(0x100e_9c3d, 6);  call_abs(memd[ds, 0x101b_ddec]);      /* call dword [0x101bddec] */
            ii(0x100e_9c43, 5);  jmp(0x100e_9b92, -0xb6); goto l_0x100e_9b92;/* jmp 0x100e9b92 */
        l_0x100e_9c48:
            ii(0x100e_9c48, 4);  cmp(memd[ss, ebp - 32], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x100e_9c4c, 2);  if(jz(0x100e_9c60, 0x12)) goto l_0x100e_9c60;/* jz 0x100e9c60 */
            ii(0x100e_9c4e, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x100e_9c53, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100e_9c56, 5);  call(Definitions.sys_call_dtor_arr, 0x7_c35d);/* call 0x10165fb8 */
            ii(0x100e_9c5b, 5);  call(Definitions.sys_delete_arr, 0x7_c378);/* call 0x10165fd8 */
        l_0x100e_9c60:
            ii(0x100e_9c60, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_9c62, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_9c63, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_9c64, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_9c65, 3);  ret(0x18);                            /* ret 0x18 */
        }
    }
}
