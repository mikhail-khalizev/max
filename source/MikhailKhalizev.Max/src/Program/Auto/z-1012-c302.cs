using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_c302-32c0dc28")]
        public void Method_1012_c302()
        {
            ii(0x1012_c302, 5); push(0x44);                             /* push 0x44 */
            ii(0x1012_c307, 5); call(Definitions.sys_check_available_stack_size, 0x3_9a46); /* call 0x10165d52 */
            ii(0x1012_c30c, 1); push(ecx);                              /* push ecx */
            ii(0x1012_c30d, 1); push(esi);                              /* push esi */
            ii(0x1012_c30e, 1); push(edi);                              /* push edi */
            ii(0x1012_c30f, 1); push(ebp);                              /* push ebp */
            ii(0x1012_c310, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_c312, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1012_c318, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_c31b, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1012_c31e, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1012_c321, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x1012_c326, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c329, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1012_c32c, 2); if(jnz(0x1012_c33c, 0xe)) goto l_0x1012_c33c; /* jnz 0x1012c33c */
            ii(0x1012_c32e, 6); mov(ax, memw[ds, 0x101c_3968]);         /* mov ax, [0x101c3968] */
            ii(0x1012_c334, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_c337, 5); jmp(0x1012_c3b5, 0x79); goto l_0x1012_c3b5; /* jmp 0x1012c3b5 */
        l_0x1012_c33c:
            ii(0x1012_c33c, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_c343, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_c34a, 2); jmp(0x1012_c352, 0x6); goto l_0x1012_c352; /* jmp 0x1012c352 */
        l_0x1012_c34c:
            ii(0x1012_c34c, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_c34f, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x1012_c352:
            ii(0x1012_c352, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c356, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_c359, 2); if(jge(0x1012_c3b5, 0x5a)) goto l_0x1012_c3b5; /* jge 0x1012c3b5 */
            ii(0x1012_c35b, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c35f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_c365, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_c36b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_c370, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c372, 2); if(jz(0x1012_c38e, 0x1a)) goto l_0x1012_c38e; /* jz 0x1012c38e */
            ii(0x1012_c374, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1012_c378, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_c37e, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_c384, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_c389, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_c38c, 2); if(jnz(0x1012_c390, 0x2)) goto l_0x1012_c390; /* jnz 0x1012c390 */
        l_0x1012_c38e:
            ii(0x1012_c38e, 2); jmp(0x1012_c3b3, 0x23); goto l_0x1012_c3b3; /* jmp 0x1012c3b3 */
        l_0x1012_c390:
            ii(0x1012_c390, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_c393, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1012_c396, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_c39b, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_c3a1, 6); mov(edx, memd[ds, eax + 0x101c_a550]);  /* mov edx, [eax+0x101ca550] */
            ii(0x1012_c3a7, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c3ab, 5); call(0x1007_6e7c, -0xb_5534);           /* call 0x10076e7c */
            ii(0x1012_c3b0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1012_c3b3:
            ii(0x1012_c3b3, 2); jmp(0x1012_c34c, -0x69); goto l_0x1012_c34c; /* jmp 0x1012c34c */
        l_0x1012_c3b5:
            ii(0x1012_c3b5, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c3b9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1012_c3bc, 2); if(jge(0x1012_c3c5, 0x7)) goto l_0x1012_c3c5; /* jge 0x1012c3c5 */
            ii(0x1012_c3be, 7); mov(memd[ss, ebp - 0x10], 0xa);         /* mov dword [ebp-0x10], 0xa */
        l_0x1012_c3c5:
            ii(0x1012_c3c5, 4); movsx(edx, memw[ss, ebp - 0x10]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_c3c9, 3); add(edx, 0xe);                          /* add edx, 0xe */
            ii(0x1012_c3cc, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1012_c3d1, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_c3d3, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_c3d6, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_c3d8, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_c3db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c3dd, 1); push(eax);                              /* push eax */
            ii(0x1012_c3de, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_c3e2, 1); push(eax);                              /* push eax */
            ii(0x1012_c3e3, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_c3e6, 3); mov(eax, memd[ds, edx + 0x50]);         /* mov eax, [edx+0x50] */
            ii(0x1012_c3e9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c3ec, 1); push(eax);                              /* push eax */
            ii(0x1012_c3ed, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_c3f0, 3); mov(eax, memd[ds, edx + 0x50]);         /* mov eax, [edx+0x50] */
            ii(0x1012_c3f3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c3f6, 1); push(eax);                              /* push eax */
            ii(0x1012_c3f7, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c3fc, 1); push(eax);                              /* push eax */
            ii(0x1012_c3fd, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c402, 1); push(eax);                              /* push eax */
            ii(0x1012_c403, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_c408, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_c40b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_c40e, 5); mov(eax, StringDefinitions.Points4);    /* mov eax, 0x101a8719 */
            ii(0x1012_c413, 5); call(0x1012_bd39, -0x6df);              /* call 0x1012bd39 */
            ii(0x1012_c418, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c41a, 1); push(eax);                              /* push eax */
            ii(0x1012_c41b, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_c41f, 1); push(eax);                              /* push eax */
            ii(0x1012_c420, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c424, 1); push(eax);                              /* push eax */
            ii(0x1012_c425, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1012_c428, 3); mov(dl, memb[ds, edx + 0x26]);          /* mov dl, [edx+0x26] */
            ii(0x1012_c42b, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1012_c431, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1012_c437, 6); mov(eax, memd[ds, edx + 0x101c_a54e]);  /* mov eax, [edx+0x101ca54e] */
            ii(0x1012_c43d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c440, 1); push(eax);                              /* push eax */
            ii(0x1012_c441, 5); mov(eax, 0x28b);                        /* mov eax, 0x28b */
            ii(0x1012_c446, 1); push(eax);                              /* push eax */
            ii(0x1012_c447, 5); mov(eax, 0x28a);                        /* mov eax, 0x28a */
            ii(0x1012_c44c, 1); push(eax);                              /* push eax */
            ii(0x1012_c44d, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1012_c452, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1012_c455, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_c458, 5); mov(eax, StringDefinitions.Total10);    /* mov eax, 0x101a8720 */
            ii(0x1012_c45d, 5); call(0x1012_bd39, -0x729);              /* call 0x1012bd39 */
            ii(0x1012_c462, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_c464, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_c465, 1); pop(edi);                               /* pop edi */
            ii(0x1012_c466, 1); pop(esi);                               /* pop esi */
            ii(0x1012_c467, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_c468, 1); ret();                                  /* ret */
        }
    }
}
