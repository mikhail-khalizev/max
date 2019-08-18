using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("97d442f3-9f67-4c81-b91c-a6e11f319916")]
        public void Method_100c_440e()
        {
            ii(0x100c_440e, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100c_4413, 5); calld(Definitions.sys_check_available_stack_size, 0xa_193a); /* call 0x10165d52 */
            ii(0x100c_4418, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_4419, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_441a, 1); pushd(esi);                             /* push esi */
            ii(0x100c_441b, 1); pushd(edi);                             /* push edi */
            ii(0x100c_441c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_441d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_441f, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100c_4425, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_4428, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_442b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_442e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_4431, 3); imul(edx, eax, 0x13);                   /* imul edx, eax, 0x13 */
            ii(0x100c_4434, 5); mov(eax, 0x101c_35b4);                  /* mov eax, 0x101c35b4 */
            ii(0x100c_4439, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_443b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_443e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4441, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_4444, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_444a, 6); mov(al, memb_a32[ds, eax + 0x101c_a4ef]); /* mov al, [eax+0x101ca4ef] */
            ii(0x100c_4450, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100c_4452, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100c_4455, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x100c_445a, 5); calld(0x1010_6752, 0x4_22f3);           /* call 0x10106752 */
            ii(0x100c_445f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_4461, 5); mov(eax, 0x48);                         /* mov eax, 0x48 */
            ii(0x100c_4466, 5); calld(0x1007_5fdc, -0x4_e48f);          /* call 0x10075fdc */
            ii(0x100c_446b, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100c_446e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_4470, 4); mov(memw_a32[ds, ebx + 0x10], ax);      /* mov [ebx+0x10], ax */
            ii(0x100c_4474, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4477, 5); calld(0x1009_caf8, -0x2_7984);          /* call 0x1009caf8 */
            ii(0x100c_447c, 7); mov(memd_a32[ss, ebp - 0x10], 0x31);    /* mov dword [ebp-0x10], 0x31 */
            ii(0x100c_4483, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100c_4486, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4489, 5); calld(0x1008_b2a8, -0x3_91e6);          /* call 0x1008b2a8 */
            ii(0x100c_448e, 7); mov(memd_a32[ss, ebp - 0xc], 0x3d);     /* mov dword [ebp-0xc], 0x3d */
            ii(0x100c_4495, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100c_4498, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_449b, 5); calld(0x1008_b2a8, -0x3_91f8);          /* call 0x1008b2a8 */
            ii(0x100c_44a0, 7); mov(memd_a32[ss, ebp - 0x20], 0x39);    /* mov dword [ebp-0x20], 0x39 */
            ii(0x100c_44a7, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100c_44aa, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44ad, 5); calld(0x1008_b2a8, -0x3_920a);          /* call 0x1008b2a8 */
            ii(0x100c_44b2, 5); calld(0x1009_cb74, -0x2_7943);          /* call 0x1009cb74 */
            ii(0x100c_44b7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_44b9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_44bb, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100c_44be, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_44c1, 5); calld(0x1009_cab0, -0x2_7a16);          /* call 0x1009cab0 */
            ii(0x100c_44c6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_44c8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_44cb, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_44ce, 5); calld(0x100d_c405, 0x1_7f32);           /* call 0x100dc405 */
            ii(0x100c_44d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_44d5, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100c_44d8, 5); calld(0x1008_8b04, -0x3_b9d9);          /* call 0x10088b04 */
            ii(0x100c_44dd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44e0, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_44e3, 5); calld(0x100c_aac8, 0x65e0);             /* call 0x100caac8 */
            ii(0x100c_44e8, 7); mov(memd_a32[ss, ebp - 0x18], 0x28);    /* mov dword [ebp-0x18], 0x28 */
            ii(0x100c_44ef, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_44f2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_44f5, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_44f8, 5); calld(0x100c_aa44, 0x6547);             /* call 0x100caa44 */
            ii(0x100c_44fd, 7); mov(memd_a32[ss, ebp - 0x1c], 0x14);    /* mov dword [ebp-0x1c], 0x14 */
            ii(0x100c_4504, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100c_4507, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_450a, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_450d, 5); calld(0x100c_aa44, 0x6532);             /* call 0x100caa44 */
            ii(0x100c_4512, 7); mov(memd_a32[ss, ebp - 0x14], 0x2);     /* mov dword [ebp-0x14], 0x2 */
            ii(0x100c_4519, 2); jmpd(0x100c_4521, 0x6); goto l_0x100c_4521; /* jmp 0x100c4521 */
        l_0x100c_451b:
            ii(0x100c_451b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_451e, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100c_4521:
            ii(0x100c_4521, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_4524, 5); calld(Definitions.my_2_get_count, -0x3_91c1); /* call 0x1008b368 */
            ii(0x100c_4529, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100c_452d, 2); if(jled(0x100c_4546, 0x17)) goto l_0x100c_4546; /* jle 0x100c4546 */
            ii(0x100c_452f, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100c_4536, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100c_4539, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_453c, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100c_453f, 5); calld(0x100c_aa44, 0x6500);             /* call 0x100caa44 */
            ii(0x100c_4544, 2); jmpd(0x100c_451b, -0x2b); goto l_0x100c_451b; /* jmp 0x100c451b */
        l_0x100c_4546:
            ii(0x100c_4546, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_4549, 3); mov(al, memb_a32[ds, eax + 0x2]);       /* mov al, [eax+0x2] */
            ii(0x100c_454c, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100c_454f, 5); if(jmpd_func(0x100c_5074, 0xb20)) return; /* jmp 0x100c5074 */
        }
    }
}
