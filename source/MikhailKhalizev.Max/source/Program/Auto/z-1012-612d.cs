using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_612d-8eaaaf93")]
        public void Method_1012_612d()
        {
            ii(0x1012_612d, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1012_6132, 5);  call(Definitions.sys_check_available_stack_size, 0x3_fc1b);/* call 0x10165d52 */
            ii(0x1012_6137, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_6138, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_6139, 1);  push(esi);                            /* push esi */
            ii(0x1012_613a, 1);  push(edi);                            /* push edi */
            ii(0x1012_613b, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_613c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_613e, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1012_6144, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_6147, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_614a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_614d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1012_6150, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x1012_6153, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6156, 5);  call(0x1015_0a5f, 0x2_a904);          /* call 0x10150a5f */
            ii(0x1012_615b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_615e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6161, 5);  call(0x1012_5fba, -0x1ac);            /* call 0x10125fba */
            ii(0x1012_6166, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_6169, 3);  mov(dl, memb[ds, eax + 14]);          /* mov dl, [eax+0xe] */
            ii(0x1012_616c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_616f, 3);  mov(memb[ds, eax + 69], dl);          /* mov [eax+0x45], dl */
            ii(0x1012_6172, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_6175, 3);  mov(al, memb[ds, eax + 15]);          /* mov al, [eax+0xf] */
            ii(0x1012_6178, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1012_617a, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1012_617d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6180, 5);  call(0x1009_c970, -0x8_9815);         /* call 0x1009c970 */
            ii(0x1012_6185, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_6188, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_618a, 3);  mov(dl, memb[ds, eax + 13]);          /* mov dl, [eax+0xd] */
            ii(0x1012_618d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_6190, 5);  call(0x100d_5410, -0x5_0d85);         /* call 0x100d5410 */
            ii(0x1012_6195, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1012_6198, 5);  call(0x1009_caf8, -0x8_96a5);         /* call 0x1009caf8 */
            ii(0x1012_619d, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_61a4, 2);  jmp(0x1012_61ac, 6); goto l_0x1012_61ac;/* jmp 0x101261ac */
        l_0x1012_61a6:
            ii(0x1012_61a6, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_61a9, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1012_61ac:
            ii(0x1012_61ac, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_61af, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1012_61b2, 4);  cmp(ax, memw[ds, edx + 16]);          /* cmp ax, [edx+0x10] */
            ii(0x1012_61b6, 2);  if(jge(0x1012_61d0, 0x18)) goto l_0x1012_61d0;/* jge 0x101261d0 */
            ii(0x1012_61b8, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_61bc, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1012_61be, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1012_61c1, 3);  add(edx, 0x12);                       /* add edx, 0x12 */
            ii(0x1012_61c4, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1012_61c6, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1012_61c9, 5);  call(0x1008_b2a8, -0x9_af26);         /* call 0x1008b2a8 */
            ii(0x1012_61ce, 2);  jmp(0x1012_61a6, -0x2a); goto l_0x1012_61a6;/* jmp 0x101261a6 */
        l_0x1012_61d0:
            ii(0x1012_61d0, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_61d3, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1012_61d7, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x1012_61d9, 5);  add(eax, 0x12);                       /* add eax, 0x12 */
            ii(0x1012_61de, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_61e1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_61e3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1012_61e6, 5);  call(0x1008_8b04, -0x9_d6e7);         /* call 0x10088b04 */
            ii(0x1012_61eb, 2);  jmp(0x1012_61f7, 0xa); goto l_0x1012_61f7;/* jmp 0x101261f7 */
        //  ii(0x1012_61ed, 10);  Недостижимый код.
        l_0x1012_61f7:
            ii(0x1012_61f7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_61fa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_61fc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_61fd, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_61fe, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_61ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_6200, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_6201, 1);  ret();                                /* ret */
        }
    }
}
