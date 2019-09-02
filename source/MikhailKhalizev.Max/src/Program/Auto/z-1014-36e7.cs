using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_36e7-9ccbb2a2")]
        public void Method_1014_36e7()
        {
            ii(0x1014_36e7, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_36ec, 5); call(Definitions.sys_check_available_stack_size, 0x2_2661); /* call 0x10165d52 */
            ii(0x1014_36f1, 1); push(esi);                              /* push esi */
            ii(0x1014_36f2, 1); push(edi);                              /* push edi */
            ii(0x1014_36f3, 1); push(ebp);                              /* push ebp */
            ii(0x1014_36f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_36f6, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_36fc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_36ff, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1014_3702, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_3705, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1014_3708, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_370b, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x1014_370e, 3); test(memd[ss, ebp - 12], eax);          /* test [ebp-0xc], eax */
            ii(0x1014_3711, 2); if(jnz(0x1014_371b, 8)) goto l_0x1014_371b; /* jnz 0x1014371b */
            ii(0x1014_3713, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1014_3716, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1014_3719, 2); if(jnz(0x1014_3720, 5)) goto l_0x1014_3720; /* jnz 0x10143720 */
        l_0x1014_371b:
            ii(0x1014_371b, 5); jmp(0x1014_37a7, 0x87); goto l_0x1014_37a7; /* jmp 0x101437a7 */
        l_0x1014_3720:
            ii(0x1014_3720, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_3723, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1014_3726, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_3729, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_372c, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_372e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3733, 3); add(eax, memd[ss, ebp - 24]);           /* add eax, [ebp-0x18] */
            ii(0x1014_3736, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1014_3739, 2); if(jle(0x1014_374d, 0x12)) goto l_0x1014_374d; /* jle 0x1014374d */
            ii(0x1014_373b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_373e, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_3740, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3745, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_3748, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1014_374a, 3); mov(memd[ss, ebp - 24], edx);           /* mov [ebp-0x18], edx */
        l_0x1014_374d:
            ii(0x1014_374d, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1014_3750, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1014_3752, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_3757, 3); cmp(eax, memd[ss, ebp - 24]);           /* cmp eax, [ebp-0x18] */
            ii(0x1014_375a, 2); if(jge(0x1014_3766, 0xa)) goto l_0x1014_3766; /* jge 0x10143766 */
            ii(0x1014_375c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_375e, 3); mov(edx, memd[ss, ebp + 16]);           /* mov edx, [ebp+0x10] */
            ii(0x1014_3761, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1014_3763, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
        l_0x1014_3766:
            ii(0x1014_3766, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_3769, 3); mov(ecx, memd[ds, eax + 12]);           /* mov ecx, [eax+0xc] */
            ii(0x1014_376c, 3); mov(ebx, memd[ss, ebp - 24]);           /* mov ebx, [ebp-0x18] */
            ii(0x1014_376f, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1014_3772, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_3775, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1014_3778, 5); call(0x1007_68e0, -0xc_ce9d);           /* call 0x100768e0 */
            ii(0x1014_377d, 5); call(0x1014_37d1, 0x4f);                /* call 0x101437d1 */
            ii(0x1014_3782, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1014_3785, 3); mov(al, memb[ss, ebp - 24]);            /* mov al, [ebp-0x18] */
            ii(0x1014_3788, 3); mov(edx, memd[ss, ebp + 16]);           /* mov edx, [ebp+0x10] */
            ii(0x1014_378b, 2); sub(memb[ds, edx], al);                 /* sub [edx], al */
            ii(0x1014_378d, 3); mov(al, memb[ss, ebp - 24]);            /* mov al, [ebp-0x18] */
            ii(0x1014_3790, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1014_3793, 2); add(memb[ds, edx], al);                 /* add [edx], al */
            ii(0x1014_3795, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1014_3798, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1014_379b, 3); add(memd[ds, edx + 16], eax);           /* add [edx+0x10], eax */
            ii(0x1014_379e, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1014_37a1, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1014_37a4, 3); sub(memd[ds, edx + 8], eax);            /* sub [edx+0x8], eax */
        l_0x1014_37a7:
            ii(0x1014_37a7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_37aa, 4); cmp(memd[ds, eax + 8], 0);              /* cmp dword [eax+0x8], 0x0 */
            ii(0x1014_37ae, 2); if(jnz(0x1014_37b9, 9)) goto l_0x1014_37b9; /* jnz 0x101437b9 */
            ii(0x1014_37b0, 7); mov(memd[ss, ebp - 28], 1);             /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1014_37b7, 2); jmp(0x1014_37c0, 7); goto l_0x1014_37c0; /* jmp 0x101437c0 */
        l_0x1014_37b9:
            ii(0x1014_37b9, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
        l_0x1014_37c0:
            ii(0x1014_37c0, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1014_37c3, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1014_37c6, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1014_37c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_37cb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_37cc, 1); pop(edi);                               /* pop edi */
            ii(0x1014_37cd, 1); pop(esi);                               /* pop esi */
            ii(0x1014_37ce, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
