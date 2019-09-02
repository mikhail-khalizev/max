using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_10ef-4f607334")]
        public void Method_100c_10ef()
        {
            ii(0x100c_10ef, 5); push(0x30);                             /* push 0x30 */
            ii(0x100c_10f4, 5); call(Definitions.sys_check_available_stack_size, 0xa_4c59); /* call 0x10165d52 */
            ii(0x100c_10f9, 1); push(ebx);                              /* push ebx */
            ii(0x100c_10fa, 1); push(ecx);                              /* push ecx */
            ii(0x100c_10fb, 1); push(esi);                              /* push esi */
            ii(0x100c_10fc, 1); push(edi);                              /* push edi */
            ii(0x100c_10fd, 1); push(ebp);                              /* push ebp */
            ii(0x100c_10fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_1100, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_1106, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_1109, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_110c, 6); mov(ax, memw[ds, 0x101c_8172]);         /* mov ax, [0x101c8172] */
            ii(0x100c_1112, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100c_1115:
            ii(0x100c_1115, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100c_1118, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100c_111d, 2); if(jz(0x100c_1162, 0x43)) goto l_0x100c_1162; /* jz 0x100c1162 */
            ii(0x100c_111f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_1122, 4); add(memd[ss, ebp - 4], 4);              /* add dword [ebp-0x4], 0x4 */
            ii(0x100c_1126, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1128, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_112b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_112e, 4); add(memd[ss, ebp - 8], 4);              /* add dword [ebp-0x8], 0x4 */
            ii(0x100c_1132, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_1134, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_1137, 6); mov(ax, memw[ds, 0x101c_8174]);         /* mov ax, [0x101c8174] */
            ii(0x100c_113d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100c_1140:
            ii(0x100c_1140, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x100c_1143, 5); cmp(memw[ss, ebp - 0xc], -1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100c_1148, 2); if(jz(0x100c_1160, 0x16)) goto l_0x100c_1160; /* jz 0x100c1160 */
            ii(0x100c_114a, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_114d, 4); add(memd[ss, ebp - 0x14], 2);           /* add dword [ebp-0x14], 0x2 */
            ii(0x100c_1151, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100c_1154, 4); add(memd[ss, ebp - 0x18], 2);           /* add dword [ebp-0x18], 0x2 */
            ii(0x100c_1158, 3); mov(dx, memw[ds, edx]);                 /* mov dx, [edx] */
            ii(0x100c_115b, 3); add(memw[ds, eax], dx);                 /* add [eax], dx */
            ii(0x100c_115e, 2); jmp(0x100c_1140, -0x20); goto l_0x100c_1140; /* jmp 0x100c1140 */
        l_0x100c_1160:
            ii(0x100c_1160, 2); jmp(0x100c_1115, -0x4d); goto l_0x100c_1115; /* jmp 0x100c1115 */
        l_0x100c_1162:
            ii(0x100c_1162, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_1164, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_1165, 1); pop(edi);                               /* pop edi */
            ii(0x100c_1166, 1); pop(esi);                               /* pop esi */
            ii(0x100c_1167, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_1168, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_1169, 1); ret();                                  /* ret */
        }
    }
}
