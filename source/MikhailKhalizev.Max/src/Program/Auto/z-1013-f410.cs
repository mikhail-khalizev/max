using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f410-dfdfc22a")]
        public void Method_1013_f410()
        {
            ii(0x1013_f410, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1013_f415, 5);  call(Definitions.sys_check_available_stack_size, 0x2_6938);/* call 0x10165d52 */
            ii(0x1013_f41a, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_f41b, 1);  push(esi);                            /* push esi */
            ii(0x1013_f41c, 1);  push(edi);                            /* push edi */
            ii(0x1013_f41d, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_f41e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_f420, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1013_f426, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_f429, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_f42c, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_f42f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f432, 3);  mov(al, memb[ds, eax + 8]);           /* mov al, [eax+0x8] */
            ii(0x1013_f435, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1013_f438, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f43b, 3);  add(eax, 8);                          /* add eax, 0x8 */
            ii(0x1013_f43e, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_f441, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_f448, 2);  jmp(0x1013_f450, 6); goto l_0x1013_f450;/* jmp 0x1013f450 */
        l_0x1013_f44a:
            ii(0x1013_f44a, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f44d, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
        l_0x1013_f450:
            ii(0x1013_f450, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_f453, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_f456, 4);  cmp(ax, memw[ds, edx + 2]);           /* cmp ax, [edx+0x2] */
            ii(0x1013_f45a, 2);  if(jge(0x1013_f4a9, 0x4d)) goto l_0x1013_f4a9;/* jge 0x1013f4a9 */
            ii(0x1013_f45c, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1013_f463, 2);  jmp(0x1013_f46b, 6); goto l_0x1013_f46b;/* jmp 0x1013f46b */
        l_0x1013_f465:
            ii(0x1013_f465, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_f468, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x1013_f46b:
            ii(0x1013_f46b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1013_f46e, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_f471, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1013_f474, 2);  if(jge(0x1013_f498, 0x22)) goto l_0x1013_f498;/* jge 0x1013f498 */
            ii(0x1013_f476, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_f479, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1013_f47b, 3);  cmp(al, memb[ss, ebp - 16]);          /* cmp al, [ebp-0x10] */
            ii(0x1013_f47e, 2);  if(jz(0x1013_f48a, 0xa)) goto l_0x1013_f48a;/* jz 0x1013f48a */
            ii(0x1013_f480, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_f483, 2);  mov(dl, memb[ds, eax]);               /* mov dl, [eax] */
            ii(0x1013_f485, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f488, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
        l_0x1013_f48a:
            ii(0x1013_f48a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f48d, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
            ii(0x1013_f490, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_f493, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x1013_f496, 2);  jmp(0x1013_f465, -0x33); goto l_0x1013_f465;/* jmp 0x1013f465 */
        l_0x1013_f498:
            ii(0x1013_f498, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f49b, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1013_f49e, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_f4a2, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1013_f4a4, 3);  add(memd[ss, ebp - 12], edx);         /* add [ebp-0xc], edx */
            ii(0x1013_f4a7, 2);  jmp(0x1013_f44a, -0x5f); goto l_0x1013_f44a;/* jmp 0x1013f44a */
        l_0x1013_f4a9:
            ii(0x1013_f4a9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_f4ab, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_f4ac, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_f4ad, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_f4ae, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_f4af, 1);  ret();                                /* ret */
        }
    }
}
