using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_45ae-2a9130ea")]
        public void Method_1014_45ae()
        {
            ii(0x1014_45ae, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_45b3, 5); call(Definitions.sys_check_available_stack_size, 0x2_179a); /* call 0x10165d52 */
            ii(0x1014_45b8, 1); push(ebx);                              /* push ebx */
            ii(0x1014_45b9, 1); push(ecx);                              /* push ecx */
            ii(0x1014_45ba, 1); push(edx);                              /* push edx */
            ii(0x1014_45bb, 1); push(esi);                              /* push esi */
            ii(0x1014_45bc, 1); push(edi);                              /* push edi */
            ii(0x1014_45bd, 1); push(ebp);                              /* push ebp */
            ii(0x1014_45be, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_45c0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_45c6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_45c9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_45cc, 6); mov(ebx, memd[ds, eax + 0x152]);        /* mov ebx, [eax+0x152] */
            ii(0x1014_45d2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_45d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_45d8, 6); mov(edx, memd[ds, eax + 0x16a]);        /* mov edx, [eax+0x16a] */
            ii(0x1014_45de, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_45e1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_45e4, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1014_45e7, 5); call(0x1014_44e6, -0x106);              /* call 0x101444e6 */
            ii(0x1014_45ec, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1014_45ee, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_45f1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_45f4, 6); mov(eax, memd[ds, eax + 0x15a]);        /* mov eax, [eax+0x15a] */
            ii(0x1014_45fa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_45fd, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1014_4600, 2); if(jge(0x1014_4611, 0xf)) goto l_0x1014_4611; /* jge 0x10144611 */
            ii(0x1014_4602, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4605, 6); mov(eax, memd[ds, eax + 0x15a]);        /* mov eax, [eax+0x15a] */
            ii(0x1014_460b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_460e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_4611:
            ii(0x1014_4611, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_4615, 2); if(jz(0x1014_466b, 0x54)) goto l_0x1014_466b; /* jz 0x1014466b */
            ii(0x1014_4617, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_461b, 2); if(jle(0x1014_4646, 0x29)) goto l_0x1014_4646; /* jle 0x10144646 */
            ii(0x1014_461d, 5); mov(ecx, 0x80);                         /* mov ecx, 0x80 */
            ii(0x1014_4622, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4625, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_462a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_462d, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4630, 5); call(0x1007_68e0, -0xc_dd55);           /* call 0x100768e0 */
            ii(0x1014_4635, 5); call(0x1014_37d1, -0xe69);              /* call 0x101437d1 */
            ii(0x1014_463a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_463c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_463f, 5); call(0x1014_4548, -0xfc);               /* call 0x10144548 */
            ii(0x1014_4644, 2); jmp(0x1014_466b, 0x25); goto l_0x1014_466b; /* jmp 0x1014466b */
        l_0x1014_4646:
            ii(0x1014_4646, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4649, 2); neg(ebx);                               /* neg ebx */
            ii(0x1014_464b, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_4650, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4653, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4656, 5); call(0x1007_68e0, -0xc_dd7b);           /* call 0x100768e0 */
            ii(0x1014_465b, 5); call(0x1014_3b69, -0xaf7);              /* call 0x10143b69 */
            ii(0x1014_4660, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_4663, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4666, 5); call(0x1014_4548, -0x123);              /* call 0x10144548 */
        l_0x1014_466b:
            ii(0x1014_466b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_466d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_466e, 1); pop(edi);                               /* pop edi */
            ii(0x1014_466f, 1); pop(esi);                               /* pop esi */
            ii(0x1014_4670, 1); pop(edx);                               /* pop edx */
            ii(0x1014_4671, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_4672, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_4673, 1); ret();                                  /* ret */
        }
    }
}
