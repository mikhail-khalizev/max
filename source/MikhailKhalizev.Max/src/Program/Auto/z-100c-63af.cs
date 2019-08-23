using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_63af-28a4641b")]
        public void Method_100c_63af()
        {
            ii(0x100c_63af, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_63b4, 5); calld(Definitions.sys_check_available_stack_size, 0x9_f999); /* call 0x10165d52 */
            ii(0x100c_63b9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_63ba, 1); pushd(esi);                             /* push esi */
            ii(0x100c_63bb, 1); pushd(edi);                             /* push edi */
            ii(0x100c_63bc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_63bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_63bf, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_63c5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_63c8, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_63cb, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_63ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_63d1, 6); mov(memw_a32[ds, eax + 0xc], 0x7fff);   /* mov word [eax+0xc], 0x7fff */
            ii(0x100c_63d7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_63da, 6); mov(memw_a32[ds, eax + 0xa], 0xffff);   /* mov word [eax+0xa], 0xffff */
            ii(0x100c_63e0, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_63e7, 2); jmpd(0x100c_63ef, 0x6); goto l_0x100c_63ef; /* jmp 0x100c63ef */
        l_0x100c_63e9:
            ii(0x100c_63e9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_63ec, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100c_63ef:
            ii(0x100c_63ef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_63f2, 5); calld(0x100c_ae28, 0x4a31);             /* call 0x100cae28 */
            ii(0x100c_63f7, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100c_63fb, 2); if(jled(0x100c_645b, 0x5e)) goto l_0x100c_645b; /* jle 0x100c645b */
            ii(0x100c_63fd, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_6401, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_6404, 5); calld(0x100c_acf0, 0x48e7);             /* call 0x100cacf0 */
            ii(0x100c_6409, 3); movsx(ebx, memb_a32[ds, eax]);          /* movsx ebx, byte [eax] */
            ii(0x100c_640c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_6410, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_6413, 5); calld(0x100c_acf0, 0x48d8);             /* call 0x100cacf0 */
            ii(0x100c_6418, 4); movsx(edx, memw_a32[ds, eax + 0x1]);    /* movsx edx, word [eax+0x1] */
            ii(0x100c_641c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_641f, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_6422, 5); calld(0x100d_fdf9, 0x1_99d2);           /* call 0x100dfdf9 */
            ii(0x100c_6427, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_642a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_642d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_6430, 4); cmp(ax, memw_a32[ds, edx + 0xc]);       /* cmp ax, [edx+0xc] */
            ii(0x100c_6434, 2); if(jged(0x100c_6459, 0x23)) goto l_0x100c_6459; /* jge 0x100c6459 */
            ii(0x100c_6436, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_643a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_643d, 5); calld(0x100c_acf0, 0x48ae);             /* call 0x100cacf0 */
            ii(0x100c_6442, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_6444, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_6447, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100c_644a, 5); calld(0x100c_a668, 0x4219);             /* call 0x100ca668 */
            ii(0x100c_644f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_6452, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_6455, 4); mov(memw_a32[ds, edx + 0xc], ax);       /* mov [edx+0xc], ax */
        l_0x100c_6459:
            ii(0x100c_6459, 2); jmpd(0x100c_63e9, -0x72); goto l_0x100c_63e9; /* jmp 0x100c63e9 */
        l_0x100c_645b:
            ii(0x100c_645b, 4); mov(memb_a32[ss, ebp - 0x10], 0x2);     /* mov byte [ebp-0x10], 0x2 */
            ii(0x100c_645f, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_6466, 2); jmpd(0x100c_646e, 0x6); goto l_0x100c_646e; /* jmp 0x100c646e */
        l_0x100c_6468:
            ii(0x100c_6468, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_646b, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100c_646e:
            ii(0x100c_646e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_6471, 5); calld(0x100c_ae28, 0x49b2);             /* call 0x100cae28 */
            ii(0x100c_6476, 4); cmp(ax, memw_a32[ss, ebp - 0x18]);      /* cmp ax, [ebp-0x18] */
            ii(0x100c_647a, 2); if(jled(0x100c_64ee, 0x72)) goto l_0x100c_64ee; /* jle 0x100c64ee */
            ii(0x100c_647c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_6480, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_6483, 5); calld(0x100c_acf0, 0x4868);             /* call 0x100cacf0 */
            ii(0x100c_6488, 3); movsx(ebx, memb_a32[ds, eax]);          /* movsx ebx, byte [eax] */
            ii(0x100c_648b, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_648f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_6492, 5); calld(0x100c_acf0, 0x4859);             /* call 0x100cacf0 */
            ii(0x100c_6497, 4); movsx(edx, memw_a32[ds, eax + 0x1]);    /* movsx edx, word [eax+0x1] */
            ii(0x100c_649b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_649e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_64a1, 5); calld(0x100d_fdf9, 0x1_9953);           /* call 0x100dfdf9 */
            ii(0x100c_64a6, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_64a9, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100c_64ad, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_64af, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100c_64b2, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_64b5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_64b8, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100c_64bb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_64be, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_64c0, 2); if(jged(0x100c_64e9, 0x27)) goto l_0x100c_64e9; /* jge 0x100c64e9 */
            ii(0x100c_64c2, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_64c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_64c9, 5); calld(0x100c_acf0, 0x4822);             /* call 0x100cacf0 */
            ii(0x100c_64ce, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_64d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_64d3, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100c_64d6, 5); calld(0x100c_a668, 0x418d);             /* call 0x100ca668 */
            ii(0x100c_64db, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_64de, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100c_64e1, 4); mov(memw_a32[ds, edx + 0xc], ax);       /* mov [edx+0xc], ax */
            ii(0x100c_64e5, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_64e9:
            ii(0x100c_64e9, 5); jmpd(0x100c_6468, -0x86); goto l_0x100c_6468; /* jmp 0x100c6468 */
        l_0x100c_64ee:
            ii(0x100c_64ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_64f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_64f1, 1); popd(edi);                              /* pop edi */
            ii(0x100c_64f2, 1); popd(esi);                              /* pop esi */
            ii(0x100c_64f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_64f4, 1); retd();                                 /* ret */
        }
    }
}
