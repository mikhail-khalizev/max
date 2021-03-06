using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_8eef-ecf425e8")]
        public void Method_100c_8eef()
        {
            ii(0x100c_8eef, 5);  push(0x48);                           /* push 0x48 */
            ii(0x100c_8ef4, 5);  call(Definitions.sys_check_available_stack_size, 0x9_ce59);/* call 0x10165d52 */
            ii(0x100c_8ef9, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8efa, 1);  push(esi);                            /* push esi */
            ii(0x100c_8efb, 1);  push(edi);                            /* push edi */
            ii(0x100c_8efc, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_8efd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_8eff, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x100c_8f05, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_8f08, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_8f0b, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_8f0e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8f11, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_8f14, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8f17, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_8f1a, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_8f1c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8f1f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_8f21, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8f24, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8f26, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100c_8f28, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_8f2a, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100c_8f2d, 3);  and(ah, 0x7f);                        /* and ah, 0x7f */
            ii(0x100c_8f30, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100c_8f33, 4);  movsx(eax, memw[ss, ebp - 40]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100c_8f37, 5);  cmp(eax, 0x7fff);                     /* cmp eax, 0x7fff */
            ii(0x100c_8f3c, 2);  if(jge(0x100c_8f49, 0xb)) goto l_0x100c_8f49;/* jge 0x100c8f49 */
            ii(0x100c_8f3e, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x100c_8f41, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_8f44, 5);  jmp(0x100c_90cc, 0x183); goto l_0x100c_90cc;/* jmp 0x100c90cc */
        l_0x100c_8f49:
            ii(0x100c_8f49, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_8f4c, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_8f4f, 5);  call(0x1007_5e64, -0x5_30f0);         /* call 0x10075e64 */
            ii(0x100c_8f54, 7);  mov(memd[ss, ebp - 20], 0x7fff);      /* mov dword [ebp-0x14], 0x7fff */
            ii(0x100c_8f5b, 5);  call(0x1014_82f4, 0x7_f394);          /* call 0x101482f4 */
            ii(0x100c_8f60, 6);  sub(eax, memd[ds, 0x101c_3974]);      /* sub eax, [0x101c3974] */
            ii(0x100c_8f66, 6);  cmp(eax, memd[ds, 0x101b_dd84]);      /* cmp eax, [0x101bdd84] */
            ii(0x100c_8f6c, 2);  if(jbe(0x100c_8f7a, 0xc)) goto l_0x100c_8f7a;/* jbe 0x100c8f7a */
            ii(0x100c_8f6e, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_8f75, 5);  jmp(0x100c_90cc, 0x152); goto l_0x100c_90cc;/* jmp 0x100c90cc */
        l_0x100c_8f7a:
            ii(0x100c_8f7a, 7);  mov(memd[ss, ebp - 36], 1);           /* mov dword [ebp-0x24], 0x1 */
            ii(0x100c_8f81, 2);  jmp(0x100c_8f89, 6); goto l_0x100c_8f89;/* jmp 0x100c8f89 */
        l_0x100c_8f83:
            ii(0x100c_8f83, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_8f86, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x100c_8f89:
            ii(0x100c_8f89, 4);  movsx(edx, memw[ss, ebp - 36]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100c_8f8d, 4);  movsx(eax, memw[ss, ebp - 36]);       /* movsx eax, word [ebp-0x24] */
            ii(0x100c_8f91, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100c_8f94, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100c_8f98, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_8f9a, 6);  if(jge(0x100c_907e, 0xde)) goto l_0x100c_907e;/* jge 0x100c907e */
            ii(0x100c_8fa0, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_8fa3, 4);  dec(memw[ss, ebp - 44]);              /* dec word [ebp-0x2c] */
            ii(0x100c_8fa7, 3);  mov(eax, memd[ss, ebp - 42]);         /* mov eax, [ebp-0x2a] */
            ii(0x100c_8faa, 4);  inc(memw[ss, ebp - 42]);              /* inc word [ebp-0x2a] */
            ii(0x100c_8fae, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_8fb5, 2);  jmp(0x100c_8fbb, 4); goto l_0x100c_8fbb;/* jmp 0x100c8fbb */
        l_0x100c_8fb7:
            ii(0x100c_8fb7, 4);  add(memd[ss, ebp - 32], 2);           /* add dword [ebp-0x20], 0x2 */
        l_0x100c_8fbb:
            ii(0x100c_8fbb, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_8fbf, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x100c_8fc2, 6);  if(jge(0x100c_9079, 0xb1)) goto l_0x100c_9079;/* jge 0x100c9079 */
            ii(0x100c_8fc8, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100c_8fcb, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_8fcd, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
        l_0x100c_8fd0:
            ii(0x100c_8fd0, 3);  dec(memd[ss, ebp - 28]);              /* dec dword [ebp-0x1c] */
            ii(0x100c_8fd3, 5);  cmp(memw[ss, ebp - 28], -1 /* 0xff */);/* cmp word [ebp-0x1c], 0xffff */
            ii(0x100c_8fd8, 6);  if(jz(0x100c_9074, 0x96)) goto l_0x100c_9074;/* jz 0x100c9074 */
            ii(0x100c_8fde, 4);  movsx(eax, memw[ss, ebp - 32]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100c_8fe2, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_8fe5, 5);  mov(edx, 0x101c_5348);                /* mov edx, 0x101c5348 */
            ii(0x100c_8fea, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_8fec, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x100c_8fef, 5);  call(0x1008_b1a4, -0x3_de50);         /* call 0x1008b1a4 */
            ii(0x100c_8ff4, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x100c_8ff8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_8ffa, 2);  if(jl(0x100c_9008, 0xc)) goto l_0x100c_9008;/* jl 0x100c9008 */
            ii(0x100c_8ffc, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x100c_8fff, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x100c_9006, 2);  if(jl(0x100c_900a, 2)) goto l_0x100c_900a;/* jl 0x100c900a */
        l_0x100c_9008:
            ii(0x100c_9008, 2);  jmp(0x100c_9012, 8); goto l_0x100c_9012;/* jmp 0x100c9012 */
        l_0x100c_900a:
            ii(0x100c_900a, 4);  movsx(eax, memw[ss, ebp - 42]);       /* movsx eax, word [ebp-0x2a] */
            ii(0x100c_900e, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_9010, 2);  if(jge(0x100c_9014, 2)) goto l_0x100c_9014;/* jge 0x100c9014 */
        l_0x100c_9012:
            ii(0x100c_9012, 2);  jmp(0x100c_9020, 0xc); goto l_0x100c_9020;/* jmp 0x100c9020 */
        l_0x100c_9014:
            ii(0x100c_9014, 3);  mov(eax, memd[ss, ebp - 42]);         /* mov eax, [ebp-0x2a] */
            ii(0x100c_9017, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x100c_901e, 2);  if(jl(0x100c_9022, 2)) goto l_0x100c_9022;/* jl 0x100c9022 */
        l_0x100c_9020:
            ii(0x100c_9020, 2);  jmp(0x100c_906f, 0x4d); goto l_0x100c_906f;/* jmp 0x100c906f */
        l_0x100c_9022:
            ii(0x100c_9022, 4);  movsx(eax, memw[ss, ebp - 44]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x100c_9026, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_9029, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x100c_902c, 4);  movsx(edx, memw[ss, ebp - 42]);       /* movsx edx, word [ebp-0x2a] */
            ii(0x100c_9030, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100c_9032, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_9034, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_9036, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_9039, 3);  test(ah, 0x80);                       /* test ah, 0x80 */
            ii(0x100c_903c, 2);  if(jz(0x100c_906f, 0x31)) goto l_0x100c_906f;/* jz 0x100c906f */
            ii(0x100c_903e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_9041, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x100c_9044, 5);  call(0x1007_5e64, -0x5_31e5);         /* call 0x10075e64 */
            ii(0x100c_9049, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_904b, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x100c_904e, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_9051, 5);  call(0x1007_5e64, -0x5_31f2);         /* call 0x10075e64 */
            ii(0x100c_9056, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x100c_9058, 5);  call(0x1007_0c51, -0x5_840c);         /* call 0x10070c51 */
            ii(0x100c_905d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_9060, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_9063, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x100c_9067, 2);  if(jge(0x100c_906f, 6)) goto l_0x100c_906f;/* jge 0x100c906f */
            ii(0x100c_9069, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_906c, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
        l_0x100c_906f:
            ii(0x100c_906f, 5);  jmp(0x100c_8fd0, -0xa4); goto l_0x100c_8fd0;/* jmp 0x100c8fd0 */
        l_0x100c_9074:
            ii(0x100c_9074, 5);  jmp(0x100c_8fb7, -0xc2); goto l_0x100c_8fb7;/* jmp 0x100c8fb7 */
        l_0x100c_9079:
            ii(0x100c_9079, 5);  jmp(0x100c_8f83, -0xfb); goto l_0x100c_8f83;/* jmp 0x100c8f83 */
        l_0x100c_907e:
            ii(0x100c_907e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_9081, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_9084, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_9087, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_908a, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_908c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_908f, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_9091, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_9094, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_9096, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100c_9098, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_909a, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100c_909d, 5);  and(eax, 0x8000);                     /* and eax, 0x8000 */
            ii(0x100c_90a2, 3);  mov(ebx, memd[ss, ebp - 20]);         /* mov ebx, [ebp-0x14] */
            ii(0x100c_90a5, 2);  or(ebx, eax);                         /* or ebx, eax */
            ii(0x100c_90a7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_90aa, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_90ad, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_90b0, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_90b3, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100c_90b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_90b8, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_90ba, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_90bd, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100c_90bf, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100c_90c1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_90c3, 3);  mov(memw[ds, eax], bx);               /* mov [eax], bx */
            ii(0x100c_90c6, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_90c9, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x100c_90cc:
            ii(0x100c_90cc, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_90cf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_90d1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_90d2, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_90d3, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_90d4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_90d5, 1);  ret();                                /* ret */
        }
    }
}
