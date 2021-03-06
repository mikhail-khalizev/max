using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_4e59-e82edbeb")]
        public void Method_1013_4e59()
        {
            ii(0x1013_4e59, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1013_4e5e, 5);  call(Definitions.sys_check_available_stack_size, 0x3_0eef);/* call 0x10165d52 */
            ii(0x1013_4e63, 1);  push(esi);                            /* push esi */
            ii(0x1013_4e64, 1);  push(edi);                            /* push edi */
            ii(0x1013_4e65, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_4e66, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_4e68, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1013_4e6e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_4e71, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_4e74, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_4e77, 3);  mov(memd[ss, ebp - 16], ecx);         /* mov [ebp-0x10], ecx */
            ii(0x1013_4e7a, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4e7e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_4e80, 2);  if(jnz(0x1013_4e8a, 8)) goto l_0x1013_4e8a;/* jnz 0x10134e8a */
            ii(0x1013_4e82, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_4e86, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_4e88, 2);  if(jz(0x1013_4e8c, 2)) goto l_0x1013_4e8c;/* jz 0x10134e8c */
        l_0x1013_4e8a:
            ii(0x1013_4e8a, 2);  jmp(0x1013_4e94, 8); goto l_0x1013_4e94;/* jmp 0x10134e94 */
        l_0x1013_4e8c:
            ii(0x1013_4e8c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4e90, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_4e92, 2);  if(jz(0x1013_4e96, 2)) goto l_0x1013_4e96;/* jz 0x10134e96 */
        l_0x1013_4e94:
            ii(0x1013_4e94, 2);  jmp(0x1013_4eab, 0x15); goto l_0x1013_4eab;/* jmp 0x10134eab */
        l_0x1013_4e96:
            ii(0x1013_4e96, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
            ii(0x1013_4e9d, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x1013_4ea4, 7);  mov(memd[ss, ebp - 4], 1);            /* mov dword [ebp-0x4], 0x1 */
        l_0x1013_4eab:
            ii(0x1013_4eab, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_4eae, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_4eb1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_4eb4, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x1013_4eb8, 2);  if(jge(0x1013_4ec0, 6)) goto l_0x1013_4ec0;/* jge 0x10134ec0 */
            ii(0x1013_4eba, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_4ebd, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_4ec0:
            ii(0x1013_4ec0, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_4ec3, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1013_4ec7, 2);  if(jge(0x1013_4ecf, 6)) goto l_0x1013_4ecf;/* jge 0x10134ecf */
            ii(0x1013_4ec9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_4ecc, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x1013_4ecf:
            ii(0x1013_4ecf, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_4ed6, 2);  jmp(0x1013_4edc, 4); goto l_0x1013_4edc;/* jmp 0x10134edc */
        l_0x1013_4ed8:
            ii(0x1013_4ed8, 4);  add(memd[ss, ebp - 20], 3);           /* add dword [ebp-0x14], 0x3 */
        l_0x1013_4edc:
            ii(0x1013_4edc, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_4ee0, 5);  cmp(eax, 0x300);                      /* cmp eax, 0x300 */
            ii(0x1013_4ee5, 6);  if(jge(0x1013_4fc8, 0xdd)) goto l_0x1013_4fc8;/* jge 0x10134fc8 */
            ii(0x1013_4eeb, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_4eef, 5);  mov(eax, memd[ds, Definitions.ptr_to_pallete]);/* mov eax, [0x101c9464] */
            ii(0x1013_4ef4, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_4ef6, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_4ef8, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x1013_4efa, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_4efd, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_4f01, 5);  mov(eax, memd[ds, Definitions.ptr_to_pallete]);/* mov eax, [0x101c9464] */
            ii(0x1013_4f06, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_4f08, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_4f0a, 3);  mov(al, memb[ds, edx + 1]);           /* mov al, [edx+0x1] */
            ii(0x1013_4f0d, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_4f10, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_4f14, 5);  mov(eax, memd[ds, Definitions.ptr_to_pallete]);/* mov eax, [0x101c9464] */
            ii(0x1013_4f19, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_4f1b, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_4f1d, 3);  mov(al, memb[ds, edx + 2]);           /* mov al, [edx+0x2] */
            ii(0x1013_4f20, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_4f23, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1013_4f26, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_4f29, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_4f2c, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x1013_4f30, 2);  if(jle(0x1013_4f38, 6)) goto l_0x1013_4f38;/* jle 0x10134f38 */
            ii(0x1013_4f32, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_4f35, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1013_4f38:
            ii(0x1013_4f38, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_4f3b, 4);  cmp(ax, memw[ss, ebp - 24]);          /* cmp ax, [ebp-0x18] */
            ii(0x1013_4f3f, 2);  if(jle(0x1013_4f47, 6)) goto l_0x1013_4f47;/* jle 0x10134f47 */
            ii(0x1013_4f41, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_4f44, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1013_4f47:
            ii(0x1013_4f47, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_4f4b, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x1013_4f4f, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_4f51, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_4f53, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_4f56, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1013_4f58, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1013_4f5a, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_4f5d, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_4f61, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_4f65, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1013_4f68, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_4f6c, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_4f6e, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_4f71, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_4f73, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_4f76, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_4f7a, 4);  movsx(edx, memw[ss, ebp - 24]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1013_4f7e, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1013_4f81, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_4f85, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_4f87, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_4f8a, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_4f8c, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_4f8f, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_4f93, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1013_4f97, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1013_4f9a, 4);  movsx(ebx, memw[ss, ebp - 28]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x1013_4f9e, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1013_4fa0, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1013_4fa3, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1013_4fa5, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_4fa8, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1013_4faa, 4);  movsx(ebx, memw[ss, ebp - 40]);       /* movsx ebx, word [ebp-0x28] */
            ii(0x1013_4fae, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1013_4fb2, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x1013_4fb6, 5);  call(0x1013_3a88, -0x1533);           /* call 0x10133a88 */
            ii(0x1013_4fbb, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1013_4fbe, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x1013_4fc1, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_4fc3, 5);  jmp(0x1013_4ed8, -0xf0); goto l_0x1013_4ed8;/* jmp 0x10134ed8 */
        l_0x1013_4fc8:
            ii(0x1013_4fc8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_4fca, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_4fcb, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_4fcc, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_4fcd, 1);  ret();                                /* ret */
        }
    }
}
