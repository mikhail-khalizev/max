using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_3476-8d230d07")]
        public void Method_1008_3476()
        {
            ii(0x1008_3476, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_347b, 5);  call(Definitions.sys_check_available_stack_size, 0xe_28d2);/* call 0x10165d52 */
            ii(0x1008_3480, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_3481, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_3482, 1);  push(esi);                            /* push esi */
            ii(0x1008_3483, 1);  push(edi);                            /* push edi */
            ii(0x1008_3484, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_3485, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_3487, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_348d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_3490, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_3493, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_3496, 3);  add(eax, 0x16);                       /* add eax, 0x16 */
            ii(0x1008_3499, 5);  call(0x1008_9d08, 0x686a);            /* call 0x10089d08 */
            ii(0x1008_349e, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x1008_34a1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_34a3, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_34a5, 5);  call(0x1008_9be4, 0x673a);            /* call 0x10089be4 */
            ii(0x1008_34aa, 2);  jmp(0x1008_34b4, 8); goto l_0x1008_34b4;/* jmp 0x100834b4 */
        l_0x1008_34ac:
            ii(0x1008_34ac, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_34af, 5);  call(0x1007_6bf8, -0xc8bc);           /* call 0x10076bf8 */
        l_0x1008_34b4:
            ii(0x1008_34b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_34b6, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_34b9, 5);  call(0x1013_ad71, 0xb_78b3);          /* call 0x1013ad71 */
            ii(0x1008_34be, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_34c0, 2);  if(jz(0x1008_34db, 0x19)) goto l_0x1008_34db;/* jz 0x100834db */
            ii(0x1008_34c2, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_34c5, 5);  call(0x1008_9b00, 0x6636);            /* call 0x10089b00 */
            ii(0x1008_34ca, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1008_34cd, 3);  add(ebx, 0x16);                       /* add ebx, 0x16 */
            ii(0x1008_34d0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_34d2, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_34d4, 5);  call(0x1008_9cd8, 0x67ff);            /* call 0x10089cd8 */
            ii(0x1008_34d9, 2);  jmp(0x1008_34ac, -0x2f); goto l_0x1008_34ac;/* jmp 0x100834ac */
        l_0x1008_34db:
            ii(0x1008_34db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_34de, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_34e1, 5);  call(0x1008_9d08, 0x6822);            /* call 0x10089d08 */
            ii(0x1008_34e6, 3);  lea(ebx, memd[ss, ebp - 12]);         /* lea ebx, [ebp-0xc] */
            ii(0x1008_34e9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_34eb, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1008_34ed, 5);  call(0x1008_9b68, 0x6676);            /* call 0x10089b68 */
            ii(0x1008_34f2, 2);  jmp(0x1008_34fc, 8); goto l_0x1008_34fc;/* jmp 0x100834fc */
        l_0x1008_34f4:
            ii(0x1008_34f4, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_34f7, 5);  call(0x1007_6bf8, -0xc904);           /* call 0x10076bf8 */
        l_0x1008_34fc:
            ii(0x1008_34fc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_34fe, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_3501, 5);  call(0x1013_ad71, 0xb_786b);          /* call 0x1013ad71 */
            ii(0x1008_3506, 2);  test(al, al);                         /* test al, al */
            ii(0x1008_3508, 2);  if(jz(0x1008_3546, 0x3c)) goto l_0x1008_3546;/* jz 0x10083546 */
            ii(0x1008_350a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_350d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_3510, 5);  call(0x1008_9acc, 0x65b7);            /* call 0x10089acc */
            ii(0x1008_3515, 5);  call(0x1008_acc4, 0x77aa);            /* call 0x1008acc4 */
            ii(0x1008_351a, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1008_351d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_3520, 5);  call(0x1008_9acc, 0x65a7);            /* call 0x10089acc */
            ii(0x1008_3525, 5);  call(0x1008_9f38, 0x6a0e);            /* call 0x10089f38 */
            ii(0x1008_352a, 5);  call(0x100b_8e30, 0x3_5901);          /* call 0x100b8e30 */
            ii(0x1008_352f, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_3532, 5);  call(0x1008_9b00, 0x65c9);            /* call 0x10089b00 */
            ii(0x1008_3537, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1008_3539, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_353c, 3);  add(eax, 0x20);                       /* add eax, 0x20 */
            ii(0x1008_353f, 5);  call(0x1008_9cd8, 0x6794);            /* call 0x10089cd8 */
            ii(0x1008_3544, 2);  jmp(0x1008_34f4, -0x52); goto l_0x1008_34f4;/* jmp 0x100834f4 */
        l_0x1008_3546:
            ii(0x1008_3546, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1008_3548, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1008_354b, 5);  call(0x1008_9044, 0x5af4);            /* call 0x10089044 */
            ii(0x1008_3550, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_3552, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_3553, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_3554, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_3555, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_3556, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_3557, 1);  ret();                                /* ret */
        }
    }
}
