using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_8457-d292d3fd")]
        public void Method_1011_8457()
        {
            ii(0x1011_8457, 5); push(0x68);                             /* push 0x68 */
            ii(0x1011_845c, 5); call(Definitions.sys_check_available_stack_size, 0x4_d8f1); /* call 0x10165d52 */
            ii(0x1011_8461, 1); push(ecx);                              /* push ecx */
            ii(0x1011_8462, 1); push(esi);                              /* push esi */
            ii(0x1011_8463, 1); push(edi);                              /* push edi */
            ii(0x1011_8464, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8465, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8467, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1011_846d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_8470, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_8473, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_8476, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8479, 5); cmp(memw[ds, eax + 8], 0x55);           /* cmp word [eax+0x8], 0x55 */
            ii(0x1011_847e, 2); if(jz(0x1011_848a, 0xa)) goto l_0x1011_848a; /* jz 0x1011848a */
            ii(0x1011_8480, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8483, 5); cmp(memw[ds, eax + 8], 0x54);           /* cmp word [eax+0x8], 0x54 */
            ii(0x1011_8488, 2); if(jnz(0x1011_848c, 2)) goto l_0x1011_848c; /* jnz 0x1011848c */
        l_0x1011_848a:
            ii(0x1011_848a, 2); jmp(0x1011_8491, 5); goto l_0x1011_8491; /* jmp 0x10118491 */
        l_0x1011_848c:
            ii(0x1011_848c, 5); jmp(0x1011_85ea, 0x159); goto l_0x1011_85ea; /* jmp 0x101185ea */
        l_0x1011_8491:
            ii(0x1011_8491, 7); mov(memd[ss, ebp - 28], 3);             /* mov dword [ebp-0x1c], 0x3 */
            ii(0x1011_8498, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_849a, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1011_849d, 3); mov(al, memb[ds, edx + 38]);            /* mov al, [edx+0x26] */
            ii(0x1011_84a0, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_84a3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_84a6, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1011_84aa, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1011_84ad, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_84b0, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1011_84b4, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1011_84b7, 7); mov(memd[ss, ebp - 40], 0);             /* mov dword [ebp-0x28], 0x0 */
            ii(0x1011_84be, 7); mov(memd[ss, ebp - 44], 0);             /* mov dword [ebp-0x2c], 0x0 */
            ii(0x1011_84c5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_84c8, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x1011_84cb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_84ce, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1011_84d2, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_84d4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_84d7, 4); movsx(ebx, memw[ss, ebp - 28]);         /* movsx ebx, word [ebp-0x1c] */
            ii(0x1011_84db, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_84dd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_84e0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_84e2, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1011_84e5, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1011_84e8, 3); mov(eax, memd[ds, edx + 22]);           /* mov eax, [edx+0x16] */
            ii(0x1011_84eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_84ee, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1011_84f2, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_84f4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x1011_84f7, 4); movsx(ebx, memw[ss, ebp - 28]);         /* movsx ebx, word [ebp-0x1c] */
            ii(0x1011_84fb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_84fd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_8500, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_8502, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x1011_8505, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1011_8508, 5); cmp(memw[ds, edx + 8], 0x55);           /* cmp word [edx+0x8], 0x55 */
            ii(0x1011_850d, 2); if(jnz(0x1011_8518, 9)) goto l_0x1011_8518; /* jnz 0x10118518 */
            ii(0x1011_850f, 7); mov(memd[ss, ebp - 32], 0x5a);          /* mov dword [ebp-0x20], 0x5a */
            ii(0x1011_8516, 2); jmp(0x1011_851f, 7); goto l_0x1011_851f; /* jmp 0x1011851f */
        l_0x1011_8518:
            ii(0x1011_8518, 7); mov(memd[ss, ebp - 32], 0x59);          /* mov dword [ebp-0x20], 0x59 */
        l_0x1011_851f:
            ii(0x1011_851f, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1011_8522, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1011_8525:
            ii(0x1011_8525, 3); dec(memd[ss, ebp - 28]);                /* dec dword [ebp-0x1c] */
            ii(0x1011_8528, 5); cmp(memw[ss, ebp - 28], -1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x1011_852d, 6); if(jz(0x1011_85ea, 0xb7)) goto l_0x1011_85ea; /* jz 0x101185ea */
            ii(0x1011_8533, 5); call(0x1010_2b84, -0x1_59b4);           /* call 0x10102b84 */
            ii(0x1011_8538, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_853d, 1); push(eax);                              /* push eax */
            ii(0x1011_853e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1011_8543, 1); push(eax);                              /* push eax */
            ii(0x1011_8544, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_8546, 1); push(eax);                              /* push eax */
            ii(0x1011_8547, 4); movsx(eax, memw[ss, ebp - 36]);         /* movsx eax, word [ebp-0x24] */
            ii(0x1011_854b, 1); push(eax);                              /* push eax */
            ii(0x1011_854c, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1011_8550, 1); push(eax);                              /* push eax */
            ii(0x1011_8551, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1011_8553, 4); movsx(ebx, memw[ss, ebp - 24]);         /* movsx ebx, word [ebp-0x18] */
            ii(0x1011_8557, 4); movsx(edx, memw[ss, ebp - 16]);         /* movsx edx, word [ebp-0x10] */
            ii(0x1011_855b, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_855e, 5); call(0x1015_a2da, 0x4_1d77);            /* call 0x1015a2da */
            ii(0x1011_8563, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_8566, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x1011_8569, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_856c, 3); mov(edx, memd[ss, ebp - 40]);           /* mov edx, [ebp-0x28] */
            ii(0x1011_856f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8572, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_8574, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_8577, 5); call(0x1007_6574, -0xa_2008);           /* call 0x10076574 */
            ii(0x1011_857c, 3); mov(eax, memd[ds, eax + 20]);           /* mov eax, [eax+0x14] */
            ii(0x1011_857f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8582, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_8584, 3); mov(memd[ss, ebp - 60], edx);           /* mov [ebp-0x3c], edx */
            ii(0x1011_8587, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_858a, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_858d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_8590, 3); mov(edx, memd[ss, ebp - 44]);           /* mov edx, [ebp-0x2c] */
            ii(0x1011_8593, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8596, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_8598, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_859b, 5); call(0x1007_6574, -0xa_202c);           /* call 0x10076574 */
            ii(0x1011_85a0, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x1011_85a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_85a6, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_85a8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_85aa, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x1011_85ad, 4); movsx(ebx, memw[ss, ebp - 56]);         /* movsx ebx, word [ebp-0x38] */
            ii(0x1011_85b1, 4); movsx(edx, memw[ss, ebp - 60]);         /* movsx edx, word [ebp-0x3c] */
            ii(0x1011_85b5, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_85b8, 5); call(0x1007_6574, -0xa_2049);           /* call 0x10076574 */
            ii(0x1011_85bd, 5); call(0x1014_9c2f, 0x3_166d);            /* call 0x10149c2f */
            ii(0x1011_85c2, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_85c5, 5); call(0x1007_6574, -0xa_2056);           /* call 0x10076574 */
            ii(0x1011_85ca, 5); call(0x1014_9fa8, 0x3_19d9);            /* call 0x10149fa8 */
            ii(0x1011_85cf, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1011_85d2, 3); add(memd[ss, ebp - 40], eax);           /* add [ebp-0x28], eax */
            ii(0x1011_85d5, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1011_85d8, 3); add(memd[ss, ebp - 44], eax);           /* add [ebp-0x2c], eax */
            ii(0x1011_85db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_85dd, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1011_85e0, 5); call(0x1007_5f2c, -0xa_26b9);           /* call 0x10075f2c */
            ii(0x1011_85e5, 5); jmp(0x1011_8525, -0xc5); goto l_0x1011_8525; /* jmp 0x10118525 */
        l_0x1011_85ea:
            ii(0x1011_85ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_85ec, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_85ed, 1); pop(edi);                               /* pop edi */
            ii(0x1011_85ee, 1); pop(esi);                               /* pop esi */
            ii(0x1011_85ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_85f0, 1); ret();                                  /* ret */
        }
    }
}
