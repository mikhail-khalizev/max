using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_883d-4a701e83")]
        public void Method_100e_883d()
        {
            ii(0x100e_883d, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100e_8842, 5); calld(Definitions.sys_check_available_stack_size, 0x7_d50b); /* call 0x10165d52 */
            ii(0x100e_8847, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_8848, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_8849, 1); pushd(edx);                             /* push edx */
            ii(0x100e_884a, 1); pushd(esi);                             /* push esi */
            ii(0x100e_884b, 1); pushd(edi);                             /* push edi */
            ii(0x100e_884c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_884d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_884f, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100e_8855, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100e_8858, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100e_885c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_885e, 2); if(jged(0x100e_8869, 0x9)) goto l_0x100e_8869; /* jge 0x100e8869 */
            ii(0x100e_8860, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x100e_8867, 2); jmpd(0x100e_8885, 0x1c); goto l_0x100e_8885; /* jmp 0x100e8885 */
        l_0x100e_8869:
            ii(0x100e_8869, 4); cmp(memb_a32[ss, ebp - 0x4], 0x3b);     /* cmp byte [ebp-0x4], 0x3b */
            ii(0x100e_886d, 2); if(jged(0x100e_8878, 0x9)) goto l_0x100e_8878; /* jge 0x100e8878 */
            ii(0x100e_886f, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x100e_8876, 2); jmpd(0x100e_887f, 0x7); goto l_0x100e_887f; /* jmp 0x100e887f */
        l_0x100e_8878:
            ii(0x100e_8878, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100e_887f:
            ii(0x100e_887f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_8882, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x100e_8885:
            ii(0x100e_8885, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_8889, 2); if(jzd(0x100e_889e, 0x13)) goto l_0x100e_889e; /* jz 0x100e889e */
            ii(0x100e_888b, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100e_888f, 3); imul(eax, eax, 0x1a);                   /* imul eax, eax, 0x1a */
            ii(0x100e_8892, 5); mov(edx, 0x101b_7f60);                  /* mov edx, 0x101b7f60 */
            ii(0x100e_8897, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_8899, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x100e_889c, 2); jmpd(0x100e_88a5, 0x7); goto l_0x100e_88a5; /* jmp 0x100e88a5 */
        l_0x100e_889e:
            ii(0x100e_889e, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100e_88a5:
            ii(0x100e_88a5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_88a8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_88ab, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_88ae, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_88b1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_88b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_88b6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_88b7, 1); popd(edi);                              /* pop edi */
            ii(0x100e_88b8, 1); popd(esi);                              /* pop esi */
            ii(0x100e_88b9, 1); popd(edx);                              /* pop edx */
            ii(0x100e_88ba, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_88bb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_88bc, 1); retd();                                 /* ret */
        }
    }
}
