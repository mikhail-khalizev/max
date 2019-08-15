using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c2724d19-6584-4383-9f93-3626e874cdf9")]
        public void Method_100d_bd53()
        {
            ii(0x100d_bd53, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100d_bd58, 5); calld(Definitions.sys_check_available_stack_size, 0x8_9ff5); /* call 0x10165d52 */
            ii(0x100d_bd5d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_bd5e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_bd5f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_bd60, 1); pushd(edi);                             /* push edi */
            ii(0x100d_bd61, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_bd62, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_bd64, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_bd6a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_bd6d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_bd70, 7); cmp(memb_a32[ds, 0x101c_37d2], 0);      /* cmp byte [0x101c37d2], 0x0 */
            ii(0x100d_bd77, 2); if(jzd(0x100d_bd80, 0x7)) goto l_0x100d_bd80; /* jz 0x100dbd80 */
            ii(0x100d_bd79, 7); mov(memd_a32[ss, ebp - 0x4], 0x3ea);    /* mov dword [ebp-0x4], 0x3ea */
        l_0x100d_bd80:
            ii(0x100d_bd80, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100d_bd84, 2); if(jled(0x100d_bd8f, 0x9)) goto l_0x100d_bd8f; /* jle 0x100dbd8f */
            ii(0x100d_bd86, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x100d_bd8d, 2); if(jld(0x100d_bd91, 0x2)) goto l_0x100d_bd91; /* jl 0x100dbd91 */
        l_0x100d_bd8f:
            ii(0x100d_bd8f, 2); jmpd(0x100d_bd9b, 0xa); goto l_0x100d_bd9b; /* jmp 0x100dbd9b */
        l_0x100d_bd91:
            ii(0x100d_bd91, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_bd94, 7); mov(memb_a32[ds, eax + 0x39e], 0);      /* mov byte [eax+0x39e], 0x0 */
        l_0x100d_bd9b:
            ii(0x100d_bd9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_bd9e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_bda1, 2); jmpd(0x100d_bdd1, 0x2e); goto l_0x100d_bdd1; /* jmp 0x100dbdd1 */
        l_0x100d_bda3:
            ii(0x100d_bda3, 5); calld(0x1011_6ba6, 0x3_adfe);           /* call 0x10116ba6 */
            ii(0x100d_bda8, 2); jmpd(0x100d_bdf6, 0x4c); goto l_0x100d_bdf6; /* jmp 0x100dbdf6 */
        l_0x100d_bdaa:
            ii(0x100d_bdaa, 5); calld(0x100d_4e6c, -0x6f43);            /* call 0x100d4e6c */
            ii(0x100d_bdaf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_bdb1, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_bdb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_bdb5, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100d_bdba, 5); calld(0x1010_5b00, 0x2_9d41);           /* call 0x10105b00 */
            ii(0x100d_bdbf, 2); jmpd(0x100d_bdf6, 0x35); goto l_0x100d_bdf6; /* jmp 0x100dbdf6 */
        l_0x100d_bdc1:
            ii(0x100d_bdc1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_bdc4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_bdc7, 5); calld(0x100d_ad31, -0x109b);            /* call 0x100dad31 */
            ii(0x100d_bdcc, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100d_bdcf, 2); jmpd(0x100d_bdfa, 0x29); goto l_0x100d_bdfa; /* jmp 0x100dbdfa */
        l_0x100d_bdd1:
            ii(0x100d_bdd1, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_bdd8, 2); if(jbd(0x100d_bdee, 0x14)) goto l_0x100d_bdee; /* jb 0x100dbdee */
            ii(0x100d_bdda, 7); cmp(memd_a32[ss, ebp - 0x10], 0x119);   /* cmp dword [ebp-0x10], 0x119 */
            ii(0x100d_bde1, 2); if(jbed(0x100d_bda3, -0x40)) goto l_0x100d_bda3; /* jbe 0x100dbda3 */
            ii(0x100d_bde3, 7); cmp(memd_a32[ss, ebp - 0x10], 0x3e9);   /* cmp dword [ebp-0x10], 0x3e9 */
            ii(0x100d_bdea, 2); if(jzd(0x100d_bdaa, -0x42)) goto l_0x100d_bdaa; /* jz 0x100dbdaa */
            ii(0x100d_bdec, 2); jmpd(0x100d_bdc1, -0x2d); goto l_0x100d_bdc1; /* jmp 0x100dbdc1 */
        l_0x100d_bdee:
            ii(0x100d_bdee, 4); cmp(memd_a32[ss, ebp - 0x10], 0x3f);    /* cmp dword [ebp-0x10], 0x3f */
            ii(0x100d_bdf2, 2); if(jzd(0x100d_bdaa, -0x4a)) goto l_0x100d_bdaa; /* jz 0x100dbdaa */
            ii(0x100d_bdf4, 2); jmpd(0x100d_bdc1, -0x35); goto l_0x100d_bdc1; /* jmp 0x100dbdc1 */
        l_0x100d_bdf6:
            ii(0x100d_bdf6, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x100d_bdfa:
            ii(0x100d_bdfa, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_bdfd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_bdff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_be00, 1); popd(edi);                              /* pop edi */
            ii(0x100d_be01, 1); popd(esi);                              /* pop esi */
            ii(0x100d_be02, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_be03, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_be04, 1); retd(); return;                         /* ret */
        }
    }
}
