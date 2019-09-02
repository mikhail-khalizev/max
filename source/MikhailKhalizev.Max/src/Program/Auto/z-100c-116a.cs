using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_116a-a9b6ee12")]
        public void Method_100c_116a()
        {
            ii(0x100c_116a, 5); push(0x38);                             /* push 0x38 */
            ii(0x100c_116f, 5); call(Definitions.sys_check_available_stack_size, 0xa_4bde); /* call 0x10165d52 */
            ii(0x100c_1174, 1); push(ebx);                              /* push ebx */
            ii(0x100c_1175, 1); push(ecx);                              /* push ecx */
            ii(0x100c_1176, 1); push(edx);                              /* push edx */
            ii(0x100c_1177, 1); push(esi);                              /* push esi */
            ii(0x100c_1178, 1); push(edi);                              /* push edi */
            ii(0x100c_1179, 1); push(ebp);                              /* push ebp */
            ii(0x100c_117a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_117c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_1182, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_1185, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100c_118b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_118e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_1191, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100c_1194, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_1197, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_119a, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100c_119d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100c_11a0:
            ii(0x100c_11a0, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x100c_11a3, 5); cmp(memw[ss, ebp - 0xc], -1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100c_11a8, 2); if(jz(0x100c_1201, 0x57)) goto l_0x100c_1201; /* jz 0x100c1201 */
            ii(0x100c_11aa, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_11ad, 4); add(memd[ss, ebp - 0x1c], 4);           /* add dword [ebp-0x1c], 0x4 */
            ii(0x100c_11b1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_11b3, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_11b6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_11b9, 4); add(memd[ss, ebp - 0x18], 4);           /* add dword [ebp-0x18], 0x4 */
            ii(0x100c_11bd, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_11bf, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_11c2, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x100c_11c8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100c_11cb:
            ii(0x100c_11cb, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x100c_11ce, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x100c_11d3, 2); if(jz(0x100c_11ff, 0x2a)) goto l_0x100c_11ff; /* jz 0x100c11ff */
            ii(0x100c_11d5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_11d8, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_11db, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_11dd, 2); if(jge(0x100c_11ef, 0x10)) goto l_0x100c_11ef; /* jge 0x100c11ef */
            ii(0x100c_11df, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_11e2, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
            ii(0x100c_11e7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_11ea, 5); mov(memw[ds, eax], 0);                  /* mov word [eax], 0x0 */
        l_0x100c_11ef:
            ii(0x100c_11ef, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_11f2, 4); add(memd[ss, ebp - 0x14], 2);           /* add dword [ebp-0x14], 0x2 */
            ii(0x100c_11f6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_11f9, 4); add(memd[ss, ebp - 0x10], 2);           /* add dword [ebp-0x10], 0x2 */
            ii(0x100c_11fd, 2); jmp(0x100c_11cb, -0x34); goto l_0x100c_11cb; /* jmp 0x100c11cb */
        l_0x100c_11ff:
            ii(0x100c_11ff, 2); jmp(0x100c_11a0, -0x61); goto l_0x100c_11a0; /* jmp 0x100c11a0 */
        l_0x100c_1201:
            ii(0x100c_1201, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_1203, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_1204, 1); pop(edi);                               /* pop edi */
            ii(0x100c_1205, 1); pop(esi);                               /* pop esi */
            ii(0x100c_1206, 1); pop(edx);                               /* pop edx */
            ii(0x100c_1207, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_1208, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_1209, 1); ret();                                  /* ret */
        }
    }
}
