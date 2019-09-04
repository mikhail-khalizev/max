using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_468c-e96a71a6")]
        public void Method_1013_468c()
        {
            ii(0x1013_468c, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1013_4691, 5);  call(Definitions.sys_check_available_stack_size, 0x3_16bc);/* call 0x10165d52 */
            ii(0x1013_4696, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_4697, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_4698, 1);  push(edx);                            /* push edx */
            ii(0x1013_4699, 1);  push(esi);                            /* push esi */
            ii(0x1013_469a, 1);  push(edi);                            /* push edi */
            ii(0x1013_469b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_469c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_469e, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1013_46a4, 5);  mov(eax, 0x1500);                     /* mov eax, 0x1500 */
            ii(0x1013_46a9, 5);  call(Definitions.sys_new_arr, 0x3_1962);/* call 0x10166010 */
            ii(0x1013_46ae, 5);  mov(memd[ds, 0x101c_9458], eax);      /* mov [0x101c9458], eax */
            ii(0x1013_46b3, 7);  cmp(memd[ds, 0x101c_9458], 0);        /* cmp dword [0x101c9458], 0x0 */
            ii(0x1013_46ba, 2);  if(jnz(0x1013_46c8, 0xc)) goto l_0x1013_46c8;/* jnz 0x101346c8 */
            ii(0x1013_46bc, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_46c3, 5);  jmp(0x1013_4967, 0x29f); goto l_0x1013_4967;/* jmp 0x10134967 */
        l_0x1013_46c8:
            ii(0x1013_46c8, 5);  mov(eax, memd[ds, 0x101c_9458]);      /* mov eax, [0x101c9458] */
            ii(0x1013_46cd, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_46d2, 2);  xor(al, al);                          /* xor al, al */
            ii(0x1013_46d4, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_46d7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_46da, 5);  mov(memd[ds, 0x101c_70a0], eax);      /* mov [0x101c70a0], eax */
            ii(0x1013_46df, 5);  mov(eax, memd[ds, 0x101c_70a0]);      /* mov eax, [0x101c70a0] */
            ii(0x1013_46e4, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_46e9, 5);  mov(memd[ds, 0x101c_70a4], eax);      /* mov [0x101c70a4], eax */
            ii(0x1013_46ee, 5);  mov(eax, memd[ds, 0x101c_70a4]);      /* mov eax, [0x101c70a4] */
            ii(0x1013_46f3, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_46f8, 5);  mov(memd[ds, 0x101c_70a8], eax);      /* mov [0x101c70a8], eax */
            ii(0x1013_46fd, 5);  mov(eax, memd[ds, 0x101c_70a8]);      /* mov eax, [0x101c70a8] */
            ii(0x1013_4702, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4707, 5);  mov(memd[ds, 0x101c_70ac], eax);      /* mov [0x101c70ac], eax */
            ii(0x1013_470c, 5);  mov(eax, memd[ds, 0x101c_70ac]);      /* mov eax, [0x101c70ac] */
            ii(0x1013_4711, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4716, 5);  mov(memd[ds, 0x101c_70b0], eax);      /* mov [0x101c70b0], eax */
            ii(0x1013_471b, 5);  mov(eax, memd[ds, 0x101c_70b0]);      /* mov eax, [0x101c70b0] */
            ii(0x1013_4720, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4725, 5);  mov(memd[ds, 0x101c_70b4], eax);      /* mov [0x101c70b4], eax */
            ii(0x1013_472a, 5);  mov(eax, memd[ds, 0x101c_70b4]);      /* mov eax, [0x101c70b4] */
            ii(0x1013_472f, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4734, 5);  mov(memd[ds, 0x101c_70b8], eax);      /* mov [0x101c70b8], eax */
            ii(0x1013_4739, 5);  mov(eax, memd[ds, 0x101c_70b8]);      /* mov eax, [0x101c70b8] */
            ii(0x1013_473e, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4743, 5);  mov(memd[ds, 0x101c_70bc], eax);      /* mov [0x101c70bc], eax */
            ii(0x1013_4748, 5);  mov(eax, memd[ds, 0x101c_70bc]);      /* mov eax, [0x101c70bc] */
            ii(0x1013_474d, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4752, 5);  mov(memd[ds, 0x101c_70c4], eax);      /* mov [0x101c70c4], eax */
            ii(0x1013_4757, 5);  mov(eax, memd[ds, 0x101c_70c4]);      /* mov eax, [0x101c70c4] */
            ii(0x1013_475c, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4761, 5);  mov(memd[ds, 0x101c_70c0], eax);      /* mov [0x101c70c0], eax */
            ii(0x1013_4766, 5);  mov(eax, memd[ds, 0x101c_70c0]);      /* mov eax, [0x101c70c0] */
            ii(0x1013_476b, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_4770, 5);  mov(memd[ds, 0x101c_70c8], eax);      /* mov [0x101c70c8], eax */
            ii(0x1013_4775, 5);  mov(eax, memd[ds, 0x101c_70c8]);      /* mov eax, [0x101c70c8] */
            ii(0x1013_477a, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_477f, 5);  mov(memd[ds, 0x101c_70cc], eax);      /* mov [0x101c70cc], eax */
            ii(0x1013_4784, 5);  mov(eax, memd[ds, 0x101c_70cc]);      /* mov eax, [0x101c70cc] */
            ii(0x1013_4789, 5);  add(eax, 0x100);                      /* add eax, 0x100 */
            ii(0x1013_478e, 5);  mov(memd[ds, 0x101c_945c], eax);      /* mov [0x101c945c], eax */
            ii(0x1013_4793, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1013_479a, 2);  jmp(0x1013_47a2, 6); goto l_0x1013_47a2;/* jmp 0x101347a2 */
        l_0x1013_479c:
            ii(0x1013_479c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_479f, 3);  inc(memd[ss, ebp - 4]);               /* inc dword [ebp-0x4] */
        l_0x1013_47a2:
            ii(0x1013_47a2, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_47a6, 5);  cmp(eax, 0x100);                      /* cmp eax, 0x100 */
            ii(0x1013_47ab, 2);  if(jge(0x1013_47fd, 0x50)) goto l_0x1013_47fd;/* jge 0x101347fd */
            ii(0x1013_47ad, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_47b1, 5);  mov(eax, memd[ds, 0x101c_70b0]);      /* mov eax, [0x101c70b0] */
            ii(0x1013_47b6, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_47b8, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_47bb, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_47bd, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_47c1, 5);  mov(eax, memd[ds, 0x101c_70ac]);      /* mov eax, [0x101c70ac] */
            ii(0x1013_47c6, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1013_47c8, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x1013_47ca, 2);  mov(memb[ds, ebx], al);               /* mov [ebx], al */
            ii(0x1013_47cc, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_47d0, 5);  mov(eax, memd[ds, 0x101c_70a8]);      /* mov eax, [0x101c70a8] */
            ii(0x1013_47d5, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1013_47d7, 2);  mov(dl, memb[ds, ebx]);               /* mov dl, [ebx] */
            ii(0x1013_47d9, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1013_47db, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1013_47df, 6);  mov(edx, memd[ds, 0x101c_70a4]);      /* mov edx, [0x101c70a4] */
            ii(0x1013_47e5, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1013_47e7, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1013_47e9, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_47eb, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_47ef, 6);  mov(ebx, memd[ds, 0x101c_70a0]);      /* mov ebx, [0x101c70a0] */
            ii(0x1013_47f5, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1013_47f7, 2);  mov(dl, memb[ds, edx]);               /* mov dl, [edx] */
            ii(0x1013_47f9, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1013_47fb, 2);  jmp(0x1013_479c, -0x61); goto l_0x1013_479c;/* jmp 0x1013479c */
        l_0x1013_47fd:
            ii(0x1013_47fd, 6);  mov(memw[ss, ebp - 4], 0);            /* mov word [ebp-0x4], 0x0 */
            ii(0x1013_4803, 7);  mov(memd[ss, ebp - 8], 0x20);         /* mov dword [ebp-0x8], 0x20 */
            ii(0x1013_480a, 2);  jmp(0x1013_4819, 0xd); goto l_0x1013_4819;/* jmp 0x10134819 */
        l_0x1013_480c:
            ii(0x1013_480c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_480f, 4);  inc(memw[ss, ebp - 4]);               /* inc word [ebp-0x4] */
            ii(0x1013_4813, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_4816, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
        l_0x1013_4819:
            ii(0x1013_4819, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_481d, 3);  cmp(eax, 0x18);                       /* cmp eax, 0x18 */
            ii(0x1013_4820, 6);  if(jge(0x1013_48cd, 0xa7)) goto l_0x1013_48cd;/* jge 0x101348cd */
            ii(0x1013_4826, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_482a, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1013_482d, 2);  if(jnz(0x1013_4833, 4)) goto l_0x1013_4833;/* jnz 0x10134833 */
            ii(0x1013_482f, 4);  add(memd[ss, ebp - 8], 8);            /* add dword [ebp-0x8], 0x8 */
        l_0x1013_4833:
            ii(0x1013_4833, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_4836, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1013_483b, 1);  cwde();                               /* cwde */
            ii(0x1013_483c, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_4840, 6);  mov(ebx, memd[ds, 0x101c_70a0]);      /* mov ebx, [0x101c70a0] */
            ii(0x1013_4846, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1013_4848, 6);  mov(al, memb[ds, eax + 0x101b_b4f0]); /* mov al, [eax+0x101bb4f0] */
            ii(0x1013_484e, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_4850, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_4853, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1013_4858, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1013_485b, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_485f, 6);  mov(ebx, memd[ds, 0x101c_70a4]);      /* mov ebx, [0x101c70a4] */
            ii(0x1013_4865, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1013_4867, 6);  mov(dl, memb[ds, edx + 0x101b_b4f8]); /* mov dl, [edx+0x101bb4f8] */
            ii(0x1013_486d, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1013_486f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_4872, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1013_4877, 1);  cwde();                               /* cwde */
            ii(0x1013_4878, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_487c, 6);  mov(edx, memd[ds, 0x101c_70a8]);      /* mov edx, [0x101c70a8] */
            ii(0x1013_4882, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1013_4884, 6);  mov(al, memb[ds, eax + 0x101b_b500]); /* mov al, [eax+0x101bb500] */
            ii(0x1013_488a, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_488c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_488f, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1013_4894, 1);  cwde();                               /* cwde */
            ii(0x1013_4895, 4);  movsx(ebx, memw[ss, ebp - 8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1013_4899, 6);  mov(edx, memd[ds, 0x101c_70ac]);      /* mov edx, [0x101c70ac] */
            ii(0x1013_489f, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x1013_48a1, 6);  mov(al, memb[ds, eax + 0x101b_b508]); /* mov al, [eax+0x101bb508] */
            ii(0x1013_48a7, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_48a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_48ac, 5);  and(eax, 7);                          /* and eax, 0x7 */
            ii(0x1013_48b1, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1013_48b4, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1013_48b8, 6);  mov(ebx, memd[ds, 0x101c_70b0]);      /* mov ebx, [0x101c70b0] */
            ii(0x1013_48be, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1013_48c0, 6);  mov(dl, memb[ds, edx + 0x101b_b510]); /* mov dl, [edx+0x101bb510] */
            ii(0x1013_48c6, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1013_48c8, 5);  jmp(0x1013_480c, -0xc1); goto l_0x1013_480c;/* jmp 0x1013480c */
        l_0x1013_48cd:
            ii(0x1013_48cd, 5);  mov(eax, memd[ds, 0x101c_945c]);      /* mov eax, [0x101c945c] */
            ii(0x1013_48d2, 5);  add(eax, 0x700);                      /* add eax, 0x700 */
            ii(0x1013_48d7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_48da, 6);  mov(memw[ss, ebp - 4], 0);            /* mov word [ebp-0x4], 0x0 */
            ii(0x1013_48e0, 2);  jmp(0x1013_48e9, 7); goto l_0x1013_48e9;/* jmp 0x101348e9 */
        l_0x1013_48e2:
            ii(0x1013_48e2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_48e5, 4);  inc(memw[ss, ebp - 4]);               /* inc word [ebp-0x4] */
        l_0x1013_48e9:
            ii(0x1013_48e9, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_48ed, 5);  cmp(eax, 0x100);                      /* cmp eax, 0x100 */
            ii(0x1013_48f2, 2);  if(jge(0x1013_4901, 0xd)) goto l_0x1013_4901;/* jge 0x10134901 */
            ii(0x1013_48f4, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_48f7, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
            ii(0x1013_48fa, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_48fd, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x1013_48ff, 2);  jmp(0x1013_48e2, -0x1f); goto l_0x1013_48e2;/* jmp 0x101348e2 */
        l_0x1013_4901:
            ii(0x1013_4901, 9);  mov(memw[ds, 0x101c_61b4], 0x2000);   /* mov word [0x101c61b4], 0x2000 */
            ii(0x1013_490a, 5);  mov(eax, memd[ds, 0x101c_70a0]);      /* mov eax, [0x101c70a0] */
            ii(0x1013_490f, 5);  mov(memd[ds, 0x101c_61b6], eax);      /* mov [0x101c61b6], eax */
            ii(0x1013_4914, 9);  mov(memw[ds, 0x101c_64b0], 0x1000);   /* mov word [0x101c64b0], 0x1000 */
            ii(0x1013_491d, 5);  mov(eax, memd[ds, 0x101c_70a4]);      /* mov eax, [0x101c70a4] */
            ii(0x1013_4922, 5);  mov(memd[ds, 0x101c_64b2], eax);      /* mov [0x101c64b2], eax */
            ii(0x1013_4927, 9);  mov(memw[ds, 0x101c_67ac], 0x800);    /* mov word [0x101c67ac], 0x800 */
            ii(0x1013_4930, 5);  mov(eax, memd[ds, 0x101c_70a8]);      /* mov eax, [0x101c70a8] */
            ii(0x1013_4935, 5);  mov(memd[ds, 0x101c_67ae], eax);      /* mov [0x101c67ae], eax */
            ii(0x1013_493a, 9);  mov(memw[ds, 0x101c_6aa8], 0x400);    /* mov word [0x101c6aa8], 0x400 */
            ii(0x1013_4943, 5);  mov(eax, memd[ds, 0x101c_70ac]);      /* mov eax, [0x101c70ac] */
            ii(0x1013_4948, 5);  mov(memd[ds, 0x101c_6aaa], eax);      /* mov [0x101c6aaa], eax */
            ii(0x1013_494d, 9);  mov(memw[ds, 0x101c_6da4], 0x8000);   /* mov word [0x101c6da4], 0x8000 */
            ii(0x1013_4956, 5);  mov(eax, memd[ds, 0x101c_70b0]);      /* mov eax, [0x101c70b0] */
            ii(0x1013_495b, 5);  mov(memd[ds, 0x101c_6da6], eax);      /* mov [0x101c6da6], eax */
            ii(0x1013_4960, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1013_4967:
            ii(0x1013_4967, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_496a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_496c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_496d, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_496e, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_496f, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_4970, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_4971, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_4972, 1);  ret();                                /* ret */
        }
    }
}
