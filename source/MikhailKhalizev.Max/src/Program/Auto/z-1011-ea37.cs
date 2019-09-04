using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_ea37-2d61937d")]
        public void Method_1011_ea37()
        {
            ii(0x1011_ea37, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1011_ea3c, 5); call(Definitions.sys_check_available_stack_size, 0x4_7311); /* call 0x10165d52 */
            ii(0x1011_ea41, 1); push(ecx);                              /* push ecx */
            ii(0x1011_ea42, 1); push(esi);                              /* push esi */
            ii(0x1011_ea43, 1); push(edi);                              /* push edi */
            ii(0x1011_ea44, 1); push(ebp);                              /* push ebp */
            ii(0x1011_ea45, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_ea47, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_ea4d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1011_ea50, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1011_ea53, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_ea56, 5); mov(eax, memd[ds, 0x101c_9454]);        /* mov eax, [0x101c9454] */
            ii(0x1011_ea5b, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1011_ea5e, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_ea65, 2); jmp(0x1011_ea6d, 6); goto l_0x1011_ea6d; /* jmp 0x1011ea6d */
        l_0x1011_ea67:
            ii(0x1011_ea67, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_ea6a, 3); inc(memd[ss, ebp - 16]);                /* inc dword [ebp-0x10] */
        l_0x1011_ea6d:
            ii(0x1011_ea6d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_ea70, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1011_ea77, 2); if(jge(0x1011_eac1, 0x48)) goto l_0x1011_eac1; /* jge 0x1011eac1 */
            ii(0x1011_ea79, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
            ii(0x1011_ea80, 2); jmp(0x1011_ea88, 6); goto l_0x1011_ea88; /* jmp 0x1011ea88 */
        l_0x1011_ea82:
            ii(0x1011_ea82, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_ea85, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
        l_0x1011_ea88:
            ii(0x1011_ea88, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_ea8b, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1011_ea92, 2); if(jge(0x1011_eabf, 0x2b)) goto l_0x1011_eabf; /* jge 0x1011eabf */
            ii(0x1011_ea94, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1011_ea97, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1011_ea9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_ea9c, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1011_ea9e, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1011_eaa2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_eaa4, 2); if(jnz(0x1011_eabd, 0x17)) goto l_0x1011_eabd; /* jnz 0x1011eabd */
            ii(0x1011_eaa6, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1011_eaaa, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_eaad, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1011_eab0, 4); movsx(ebx, memw[ss, ebp - 16]);         /* movsx ebx, word [ebp-0x10] */
            ii(0x1011_eab4, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1011_eab6, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1011_eab8, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1011_eabb, 2); mov(memb[ds, edx], al);                 /* mov [edx], al */
        l_0x1011_eabd:
            ii(0x1011_eabd, 2); jmp(0x1011_ea82, -0x3d); goto l_0x1011_ea82; /* jmp 0x1011ea82 */
        l_0x1011_eabf:
            ii(0x1011_eabf, 2); jmp(0x1011_ea67, -0x5a); goto l_0x1011_ea67; /* jmp 0x1011ea67 */
        l_0x1011_eac1:
            ii(0x1011_eac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_eac3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_eac4, 1); pop(edi);                               /* pop edi */
            ii(0x1011_eac5, 1); pop(esi);                               /* pop esi */
            ii(0x1011_eac6, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_eac7, 1); ret();                                  /* ret */
        }
    }
}
