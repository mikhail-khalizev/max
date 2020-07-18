using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_3985-8a177e1")]
        public void Method_1010_3985()
        {
            ii(0x1010_3985, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1010_398a, 5);  call(Definitions.sys_check_available_stack_size, 0x6_23c3);/* call 0x10165d52 */
            ii(0x1010_398f, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_3990, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_3991, 1);  push(esi);                            /* push esi */
            ii(0x1010_3992, 1);  push(edi);                            /* push edi */
            ii(0x1010_3993, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_3994, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_3996, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1010_399c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_399f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_39a2, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1010_39a6, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_39a9, 5);  call(0x1010_45d4, 0xc26);             /* call 0x101045d4 */
            ii(0x1010_39ae, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_39b1, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1010_39b5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_39b8, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1010_39bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_39be, 5);  call(0x1013_c0fa, 0x3_8737);          /* call 0x1013c0fa */
            ii(0x1010_39c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_39c6, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1010_39c8, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1010_39cb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_39ce, 5);  call(0x1013_c0fa, 0x3_8727);          /* call 0x1013c0fa */
            ii(0x1010_39d3, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_39da, 2);  jmp(0x1010_39e2, 6); goto l_0x1010_39e2;/* jmp 0x101039e2 */
        l_0x1010_39dc:
            ii(0x1010_39dc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_39df, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1010_39e2:
            ii(0x1010_39e2, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_39e5, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1010_39e8, 3);  cmp(ax, memw[ds, edx]);               /* cmp ax, [edx] */
            ii(0x1010_39eb, 2);  if(jge(0x1010_3a56, 0x69)) goto l_0x1010_3a56;/* jge 0x10103a56 */
            ii(0x1010_39ed, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_39f1, 3);  imul(edx, eax, 0xa);                  /* imul edx, eax, 0xa */
            ii(0x1010_39f4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_39f7, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1010_39fa, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_39fc, 5);  call(0x1007_6b90, -0x8_ce71);         /* call 0x10076b90 */
            ii(0x1010_3a01, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1010_3a04, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_3a07, 5);  call(0x1013_c0fa, 0x3_86ee);          /* call 0x1013c0fa */
            ii(0x1010_3a0c, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1010_3a10, 3);  imul(edx, eax, 0xa);                  /* imul edx, eax, 0xa */
            ii(0x1010_3a13, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_3a16, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1010_3a19, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1010_3a1b, 5);  call(0x1010_46a4, 0xc84);             /* call 0x101046a4 */
            ii(0x1010_3a20, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_3a22, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3a25, 5);  call(0x1010_4514, 0xaea);             /* call 0x10104514 */
            ii(0x1010_3a2a, 2);  jmp(0x1010_3a34, 8); goto l_0x1010_3a34;/* jmp 0x10103a34 */
        l_0x1010_3a2c:
            ii(0x1010_3a2c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3a2f, 5);  call(0x1007_6bf8, -0x8_ce3c);         /* call 0x10076bf8 */
        l_0x1010_3a34:
            ii(0x1010_3a34, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_3a36, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3a39, 5);  call(0x1013_ad71, 0x3_7333);          /* call 0x1013ad71 */
            ii(0x1010_3a3e, 2);  test(al, al);                         /* test al, al */
            ii(0x1010_3a40, 2);  if(jz(0x1010_3a54, 0x12)) goto l_0x1010_3a54;/* jz 0x10103a54 */
            ii(0x1010_3a42, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_3a45, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3a48, 5);  call(0x1010_44b0, 0xa63);             /* call 0x101044b0 */
            ii(0x1010_3a4d, 5);  call(0x1010_312d, -0x925);            /* call 0x1010312d */
            ii(0x1010_3a52, 2);  jmp(0x1010_3a2c, -0x28); goto l_0x1010_3a2c;/* jmp 0x10103a2c */
        l_0x1010_3a54:
            ii(0x1010_3a54, 2);  jmp(0x1010_39dc, -0x7a); goto l_0x1010_39dc;/* jmp 0x101039dc */
        l_0x1010_3a56:
            ii(0x1010_3a56, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_3a58, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1010_3a5b, 5);  call(0x1010_4470, 0xa10);             /* call 0x10104470 */
            ii(0x1010_3a60, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_3a62, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_3a63, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_3a64, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_3a65, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_3a66, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_3a67, 1);  ret();                                /* ret */
        }
    }
}
