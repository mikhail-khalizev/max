using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_8200-da8314a3")]
        public void Method_1009_8200()
        {
            ii(0x1009_8200, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1009_8205, 5);  call(Definitions.sys_check_available_stack_size, 0xc_db48);/* call 0x10165d52 */
            ii(0x1009_820a, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_820b, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_820c, 1);  push(esi);                            /* push esi */
            ii(0x1009_820d, 1);  push(edi);                            /* push edi */
            ii(0x1009_820e, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_820f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_8211, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1009_8217, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_821a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_821d, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_8220, 5);  call(Definitions.my_ctor_0x101b_4184, -0x2_1735);/* call 0x10076af0 */
            ii(0x1009_8225, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8227, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_822a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_822c, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_822d, 5);  call(0x1007_6e7c, -0x2_13b6);         /* call 0x10076e7c */
            ii(0x1009_8232, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_8235, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_8237, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_823a, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1009_823d, 1);  dec(eax);                             /* dec eax */
            ii(0x1009_823e, 5);  call(0x1007_6e7c, -0x2_13c7);         /* call 0x10076e7c */
            ii(0x1009_8243, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_8246, 5);  mov(eax, memd[ds, 0x101c_8170]);      /* mov eax, [0x101c8170] */
            ii(0x1009_824b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_824e, 3);  lea(edx, memd[ds, eax - 1]);          /* lea edx, [eax-0x1] */
            ii(0x1009_8251, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8254, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x1009_8257, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_8258, 5);  call(Definitions.my_min, -0xead9);    /* call 0x10089784 */
            ii(0x1009_825d, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_8260, 6);  mov(edx, memd[ds, 0x101c_8172]);      /* mov edx, [0x101c8172] */
            ii(0x1009_8266, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_8269, 1);  dec(edx);                             /* dec edx */
            ii(0x1009_826a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_826d, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x1009_8270, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_8271, 5);  call(Definitions.my_min, -0xeaf2);    /* call 0x10089784 */
            ii(0x1009_8276, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_8279, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_827c, 4);  mov(memw[ss, ebp - 16], ax);          /* mov [ebp-0x10], ax */
            ii(0x1009_8280, 2);  jmp(0x1009_8289, 7); goto l_0x1009_8289;/* jmp 0x10098289 */
        l_0x1009_8282:
            ii(0x1009_8282, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_8285, 4);  inc(memw[ss, ebp - 16]);              /* inc word [ebp-0x10] */
        l_0x1009_8289:
            ii(0x1009_8289, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_828d, 3);  cmp(eax, memd[ss, ebp - 24]);         /* cmp eax, [ebp-0x18] */
            ii(0x1009_8290, 2);  if(jge(0x1009_82dd, 0x4b)) goto l_0x1009_82dd;/* jge 0x100982dd */
            ii(0x1009_8292, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_8295, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x1009_8299, 4);  mov(memw[ss, ebp - 14], ax);          /* mov [ebp-0xe], ax */
            ii(0x1009_829d, 2);  jmp(0x1009_82a6, 7); goto l_0x1009_82a6;/* jmp 0x100982a6 */
        l_0x1009_829f:
            ii(0x1009_829f, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x1009_82a2, 4);  inc(memw[ss, ebp - 14]);              /* inc word [ebp-0xe] */
        l_0x1009_82a6:
            ii(0x1009_82a6, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x1009_82aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_82ad, 3);  cmp(edx, memd[ds, eax + 12]);         /* cmp edx, [eax+0xc] */
            ii(0x1009_82b0, 2);  if(jge(0x1009_82db, 0x29)) goto l_0x1009_82db;/* jge 0x100982db */
            ii(0x1009_82b2, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_82b6, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_82b9, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1009_82bc, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x1009_82c0, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_82c2, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_82c4, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_82c6, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_82cb, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1009_82ce, 2);  if(jnz(0x1009_82d9, 9)) goto l_0x1009_82d9;/* jnz 0x100982d9 */
            ii(0x1009_82d0, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_82d4, 5);  jmp(0x1009_8341, 0x68); goto l_0x1009_8341;/* jmp 0x10098341 */
        l_0x1009_82d9:
            ii(0x1009_82d9, 2);  jmp(0x1009_829f, -0x3c); goto l_0x1009_829f;/* jmp 0x1009829f */
        l_0x1009_82db:
            ii(0x1009_82db, 2);  jmp(0x1009_8282, -0x5b); goto l_0x1009_8282;/* jmp 0x10098282 */
        l_0x1009_82dd:
            ii(0x1009_82dd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_82e0, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1009_82e3, 4);  mov(memw[ss, ebp - 16], ax);          /* mov [ebp-0x10], ax */
            ii(0x1009_82e7, 2);  jmp(0x1009_82f0, 7); goto l_0x1009_82f0;/* jmp 0x100982f0 */
        l_0x1009_82e9:
            ii(0x1009_82e9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_82ec, 4);  inc(memw[ss, ebp - 16]);              /* inc word [ebp-0x10] */
        l_0x1009_82f0:
            ii(0x1009_82f0, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1009_82f4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_82f7, 3);  cmp(edx, memd[ds, eax + 8]);          /* cmp edx, [eax+0x8] */
            ii(0x1009_82fa, 2);  if(jge(0x1009_833d, 0x41)) goto l_0x1009_833d;/* jge 0x1009833d */
            ii(0x1009_82fc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_82ff, 4);  mov(memw[ss, ebp - 14], ax);          /* mov [ebp-0xe], ax */
            ii(0x1009_8303, 2);  jmp(0x1009_830c, 7); goto l_0x1009_830c;/* jmp 0x1009830c */
        l_0x1009_8305:
            ii(0x1009_8305, 3);  mov(eax, memd[ss, ebp - 14]);         /* mov eax, [ebp-0xe] */
            ii(0x1009_8308, 4);  inc(memw[ss, ebp - 14]);              /* inc word [ebp-0xe] */
        l_0x1009_830c:
            ii(0x1009_830c, 4);  movsx(eax, memw[ss, ebp - 14]);       /* movsx eax, word [ebp-0xe] */
            ii(0x1009_8310, 3);  cmp(eax, memd[ss, ebp - 20]);         /* cmp eax, [ebp-0x14] */
            ii(0x1009_8313, 2);  if(jge(0x1009_833b, 0x26)) goto l_0x1009_833b;/* jge 0x1009833b */
            ii(0x1009_8315, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1009_8319, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_831c, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1009_831f, 4);  movsx(edx, memw[ss, ebp - 14]);       /* movsx edx, word [ebp-0xe] */
            ii(0x1009_8323, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_8325, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1009_8327, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x1009_8329, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_832e, 3);  cmp(eax, 3);                          /* cmp eax, 0x3 */
            ii(0x1009_8331, 2);  if(jnz(0x1009_8339, 6)) goto l_0x1009_8339;/* jnz 0x10098339 */
            ii(0x1009_8333, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_8337, 2);  jmp(0x1009_8341, 8); goto l_0x1009_8341;/* jmp 0x10098341 */
        l_0x1009_8339:
            ii(0x1009_8339, 2);  jmp(0x1009_8305, -0x36); goto l_0x1009_8305;/* jmp 0x10098305 */
        l_0x1009_833b:
            ii(0x1009_833b, 2);  jmp(0x1009_82e9, -0x54); goto l_0x1009_82e9;/* jmp 0x100982e9 */
        l_0x1009_833d:
            ii(0x1009_833d, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1009_8341:
            ii(0x1009_8341, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1009_8344, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_8346, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_8347, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_8348, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_8349, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_834a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_834b, 1);  ret();                                /* ret */
        }
    }
}
