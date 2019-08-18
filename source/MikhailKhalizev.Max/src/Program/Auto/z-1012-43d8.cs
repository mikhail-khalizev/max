using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b6eb04c1-dc19-4685-965e-7694c41f2e1a")]
        public void Method_1012_43d8()
        {
            ii(0x1012_43d8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_43dd, 5); calld(Definitions.sys_check_available_stack_size, 0x4_1970); /* call 0x10165d52 */
            ii(0x1012_43e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_43e3, 1); pushd(esi);                             /* push esi */
            ii(0x1012_43e4, 1); pushd(edi);                             /* push edi */
            ii(0x1012_43e5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_43e6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_43e8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_43ee, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_43f1, 1); pushd(eax);                             /* push eax */
            ii(0x1012_43f2, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_43f5, 1); pushd(eax);                             /* push eax */
            ii(0x1012_43f6, 5); calld(0x1012_36fa, -0xd01);             /* call 0x101236fa */
            ii(0x1012_43fb, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_43fe, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4400, 2); if(jzd(0x1012_440e, 0xc)) goto l_0x1012_440e; /* jz 0x1012440e */
            ii(0x1012_4402, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_4409, 5); jmpd(0x1012_44e4, 0xd6); goto l_0x1012_44e4; /* jmp 0x101244e4 */
        l_0x1012_440e:
            ii(0x1012_440e, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4411, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_4417, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_441a, 6); mov(eax, memd_a32[ds, eax + 0x88]);     /* mov eax, [eax+0x88] */
            ii(0x1012_4420, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_4422, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_4425, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_4428, 5); calld(Definitions.sys_strlen, 0x4_da9a); /* call 0x10171ec7 */
            ii(0x1012_442d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1012_4430, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_4433, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4436, 6); mov(edx, memd_a32[ds, eax + 0x88]);     /* mov edx, [eax+0x88] */
            ii(0x1012_443c, 3); add(edx, memd_a32[ss, ebp - 0x4]);      /* add edx, [ebp-0x4] */
            ii(0x1012_443f, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4442, 6); cmp(edx, memd_a32[ds, eax + 0x8c]);     /* cmp edx, [eax+0x8c] */
            ii(0x1012_4448, 2); if(jbed(0x1012_4456, 0xc)) goto l_0x1012_4456; /* jbe 0x10124456 */
            ii(0x1012_444a, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_4451, 5); jmpd(0x1012_44e4, 0x8e); goto l_0x1012_44e4; /* jmp 0x101244e4 */
        l_0x1012_4456:
            ii(0x1012_4456, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4459, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_445c, 3); mov(memb_a32[ds, eax], 0xd);            /* mov byte [eax], 0xd */
            ii(0x1012_445f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4462, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_4465, 3); mov(memb_a32[ds, eax], 0xa);            /* mov byte [eax], 0xa */
            ii(0x1012_4468, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_446b, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_446e, 6); mov(memd_a32[ds, edx + 0x98], eax);     /* mov [edx+0x98], eax */
            ii(0x1012_4474, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4477, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_447a, 3); mov(memb_a32[ds, eax], 0x5b);           /* mov byte [eax], 0x5b */
        l_0x1012_447d:
            ii(0x1012_447d, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_4480, 3); cmp(memb_a32[ds, eax], 0);              /* cmp byte [eax], 0x0 */
            ii(0x1012_4483, 2); if(jzd(0x1012_4497, 0x12)) goto l_0x1012_4497; /* jz 0x10124497 */
            ii(0x1012_4485, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_4488, 3); inc(memd_a32[ss, ebp + 0x18]);          /* inc dword [ebp+0x18] */
            ii(0x1012_448b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_448e, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_4491, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_4493, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1012_4495, 2); jmpd(0x1012_447d, -0x1a); goto l_0x1012_447d; /* jmp 0x1012447d */
        l_0x1012_4497:
            ii(0x1012_4497, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_449a, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_449d, 3); mov(memb_a32[ds, eax], 0x5d);           /* mov byte [eax], 0x5d */
            ii(0x1012_44a0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_44a3, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_44a6, 3); mov(memb_a32[ds, eax], 0xd);            /* mov byte [eax], 0xd */
            ii(0x1012_44a9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_44ac, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_44af, 3); mov(memb_a32[ds, eax], 0xa);            /* mov byte [eax], 0xa */
            ii(0x1012_44b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_44b5, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_44b8, 6); mov(memd_a32[ds, edx + 0xa8], eax);     /* mov [edx+0xa8], eax */
            ii(0x1012_44be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_44c1, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_44c4, 6); mov(memd_a32[ds, edx + 0x90], eax);     /* mov [edx+0x90], eax */
            ii(0x1012_44ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_44cd, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_44d0, 6); add(memd_a32[ds, edx + 0x88], eax);     /* add [edx+0x88], eax */
            ii(0x1012_44d6, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_44d9, 4); or(memb_a32[ds, eax + 0x1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_44dd, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_44e4:
            ii(0x1012_44e4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_44e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_44e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_44ea, 1); popd(edi);                              /* pop edi */
            ii(0x1012_44eb, 1); popd(esi);                              /* pop esi */
            ii(0x1012_44ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_44ed, 1); retd(); return;                         /* ret */
        }
    }
}
