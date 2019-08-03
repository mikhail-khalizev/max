using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("977f5aed-0e3e-4ab7-bace-24d75238be99")]
        public void /* sys */ Method_1016_bcc4()
        {
            ii(0x1016_bcc4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_bcc5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_bcc6, 1); pushd(edx);                             /* push edx */
            ii(0x1016_bcc7, 1); pushd(esi);                             /* push esi */
            ii(0x1016_bcc8, 1); pushd(edi);                             /* push edi */
            ii(0x1016_bcc9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_bcca, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_bccd, 6); mov(ebp, memd_a32[ds, 0x101b_de60]);    /* mov ebp, [0x101bde60] */
            ii(0x1016_bcd3, 7); cmp(memd_a32[ds, 0x101c_fbe8], 0);      /* cmp dword [0x101cfbe8], 0x0 */
            ii(0x1016_bcda, 6); if(jzd(0x1016_be21, 0x141)) goto l_0x1016_be21; /* jz 0x1016be21 */
            ii(0x1016_bce0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_bce2, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_bce4, 6); mov(memd_a32[ds, 0x101c_fb90], ebx);    /* mov [0x101cfb90], ebx */
            ii(0x1016_bcea, 5); calld(/* sys */ 0x1016_7d1c, -0x3fd3);  /* call 0x10167d1c */
            ii(0x1016_bcef, 3); mov(memd_a32[ss, esp], ebx);            /* mov [esp], ebx */
            ii(0x1016_bcf2, 4); mov(memd_a32[ss, esp + 0x4], ebx);      /* mov [esp+0x4], ebx */
            ii(0x1016_bcf6, 6); mov(edi, memd_a32[ds, 0x101c_fb94]);    /* mov edi, [0x101cfb94] */
            ii(0x1016_bcfc, 6); mov(ebp, memd_a32[ds, 0x101b_de60]);    /* mov ebp, [0x101bde60] */
            ii(0x1016_bd02, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_bd04, 2); if(jled(0x1016_bd5d, 0x57)) goto l_0x1016_bd5d; /* jle 0x1016bd5d */
        l_0x1016_bd06:
            ii(0x1016_bd06, 6); mov(ecx, memd_a32[ds, 0x101c_fbf0]);    /* mov ecx, [0x101cfbf0] */
            ii(0x1016_bd0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_bd0e, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_bd10, 2); if(jled(0x1016_bd3a, 0x28)) goto l_0x1016_bd3a; /* jle 0x1016bd3a */
            ii(0x1016_bd12, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
        l_0x1016_bd16:
            ii(0x1016_bd16, 6); mov(esi, memd_a32[ds, 0x101b_de64]);    /* mov esi, [0x101bde64] */
            ii(0x1016_bd1c, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_bd1e, 2); mov(cl, memb_a32[ds, esi]);             /* mov cl, [esi] */
            ii(0x1016_bd20, 6); cmp(cl, memb_a32[ds, 0x101c_fc04]);     /* cmp cl, [0x101cfc04] */
            ii(0x1016_bd26, 2); if(jzd(0x1016_bd2d, 0x5)) goto l_0x1016_bd2d; /* jz 0x1016bd2d */
            ii(0x1016_bd28, 3); lea(edi, ebx + ebp);                    /* lea edi, [ebx+ebp] */
            ii(0x1016_bd2b, 2); mov(memb_a32[ds, edi], cl);             /* mov [edi], cl */
        l_0x1016_bd2d:
            ii(0x1016_bd2d, 6); mov(esi, memd_a32[ds, 0x101c_fbf0]);    /* mov esi, [0x101cfbf0] */
            ii(0x1016_bd33, 1); inc(eax);                               /* inc eax */
            ii(0x1016_bd34, 1); inc(edx);                               /* inc edx */
            ii(0x1016_bd35, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_bd36, 2); cmp(edx, esi);                          /* cmp edx, esi */
            ii(0x1016_bd38, 2); if(jld(0x1016_bd16, -0x24)) goto l_0x1016_bd16; /* jl 0x1016bd16 */
        l_0x1016_bd3a:
            ii(0x1016_bd3a, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_bd3d, 1); inc(eax);                               /* inc eax */
            ii(0x1016_bd3e, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_bd42, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_bd45, 5); mov(eax, memd_a32[ds, 0x101c_fbec]);    /* mov eax, [0x101cfbec] */
            ii(0x1016_bd4a, 6); mov(ecx, memd_a32[ds, 0x101c_fb94]);    /* mov ecx, [0x101cfb94] */
            ii(0x1016_bd50, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_bd52, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_bd55, 4); mov(memd_a32[ss, esp + 0x4], edx);      /* mov [esp+0x4], edx */
            ii(0x1016_bd59, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_bd5b, 2); if(jld(0x1016_bd06, -0x57)) goto l_0x1016_bd06; /* jl 0x1016bd06 */
        l_0x1016_bd5d:
            ii(0x1016_bd5d, 5); mov(eax, memd_a32[ds, 0x101c_fbd4]);    /* mov eax, [0x101cfbd4] */
            ii(0x1016_bd62, 6); mov(esi, memd_a32[ds, 0x1020_88e0]);    /* mov esi, [0x102088e0] */
            ii(0x1016_bd68, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_bd6a, 2); if(jged(0x1016_bd7a, 0xe)) goto l_0x1016_bd7a; /* jge 0x1016bd7a */
            ii(0x1016_bd6c, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_bd6e, 6); mov(ebx, memd_a32[ds, 0x101c_fbf0]);    /* mov ebx, [0x101cfbf0] */
            ii(0x1016_bd74, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1016_bd76, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1016_bd78, 2); jmpd(0x1016_bda3, 0x29); goto l_0x1016_bda3; /* jmp 0x1016bda3 */
        l_0x1016_bd7a:
            ii(0x1016_bd7a, 6); mov(edi, memd_a32[ds, 0x101c_fbf0]);    /* mov edi, [0x101cfbf0] */
            ii(0x1016_bd80, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_bd82, 6); mov(edx, memd_a32[ds, 0x1020_88e8]);    /* mov edx, [0x102088e8] */
            ii(0x1016_bd88, 1); dec(eax);                               /* dec eax */
            ii(0x1016_bd89, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_bd8b, 2); if(jled(0x1016_bd9f, 0x12)) goto l_0x1016_bd9f; /* jle 0x1016bd9f */
            ii(0x1016_bd8d, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_bd92, 6); sub(eax, memd_a32[ds, 0x101c_fbd4]);    /* sub eax, [0x101cfbd4] */
            ii(0x1016_bd98, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_bd9a, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x1016_bd9d, 2); jmpd(0x1016_bda3, 0x4); goto l_0x1016_bda3; /* jmp 0x1016bda3 */
        l_0x1016_bd9f:
            ii(0x1016_bd9f, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_bda1, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1016_bda3:
            ii(0x1016_bda3, 5); mov(eax, memd_a32[ds, 0x101c_fbd0]);    /* mov eax, [0x101cfbd0] */
            ii(0x1016_bda8, 6); mov(esi, memd_a32[ds, 0x1020_88e4]);    /* mov esi, [0x102088e4] */
            ii(0x1016_bdae, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1016_bdb0, 2); if(jged(0x1016_bdc6, 0x14)) goto l_0x1016_bdc6; /* jge 0x1016bdc6 */
            ii(0x1016_bdb2, 6); mov(edi, memd_a32[ds, 0x101c_fbd0]);    /* mov edi, [0x101cfbd0] */
            ii(0x1016_bdb8, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_bdba, 6); mov(ecx, memd_a32[ds, 0x101c_fb94]);    /* mov ecx, [0x101cfb94] */
            ii(0x1016_bdc0, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_bdc2, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1016_bdc4, 2); jmpd(0x1016_bde8, 0x22); goto l_0x1016_bde8; /* jmp 0x1016bde8 */
        l_0x1016_bdc6:
            ii(0x1016_bdc6, 6); mov(edi, memd_a32[ds, 0x101c_fb94]);    /* mov edi, [0x101cfb94] */
            ii(0x1016_bdcc, 2); add(eax, edi);                          /* add eax, edi */
            ii(0x1016_bdce, 6); mov(ecx, memd_a32[ds, 0x1020_88ec]);    /* mov ecx, [0x102088ec] */
            ii(0x1016_bdd4, 1); dec(eax);                               /* dec eax */
            ii(0x1016_bdd5, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1016_bdd7, 2); if(jled(0x1016_bde4, 0xb)) goto l_0x1016_bde4; /* jle 0x1016bde4 */
            ii(0x1016_bdd9, 6); sub(ecx, memd_a32[ds, 0x101c_fbd0]);    /* sub ecx, [0x101cfbd0] */
            ii(0x1016_bddf, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_bde1, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_bde2, 2); jmpd(0x1016_bde8, 0x4); goto l_0x1016_bde8; /* jmp 0x1016bde8 */
        l_0x1016_bde4:
            ii(0x1016_bde4, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1016_bde6, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_bde8:
            ii(0x1016_bde8, 6); mov(esi, memd_a32[ds, 0x101c_fbd0]);    /* mov esi, [0x101cfbd0] */
            ii(0x1016_bdee, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_bdf0, 1); pushd(esi);                             /* push esi */
            ii(0x1016_bdf1, 6); mov(esi, memd_a32[ds, 0x101c_fbd4]);    /* mov esi, [0x101cfbd4] */
            ii(0x1016_bdf7, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1016_bdf9, 1); pushd(esi);                             /* push esi */
            ii(0x1016_bdfa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_bdfb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_bdfc, 1); pushd(eax);                             /* push eax */
            ii(0x1016_bdfd, 1); pushd(edx);                             /* push edx */
            ii(0x1016_bdfe, 5); mov(eax, memd_a32[ds, 0x101c_fb94]);    /* mov eax, [0x101cfb94] */
            ii(0x1016_be03, 1); pushd(eax);                             /* push eax */
            ii(0x1016_be04, 6); mov(edx, memd_a32[ds, 0x101c_fbf0]);    /* mov edx, [0x101cfbf0] */
            ii(0x1016_be0a, 1); pushd(edx);                             /* push edx */
            ii(0x1016_be0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_be0c, 6); mov(memd_a32[ds, 0x101b_de60], ebp);    /* mov [0x101bde60], ebp */
            ii(0x1016_be12, 6); calld_abs(memd_a32[ds, 0x101c_fc00]);   /* call dword [0x101cfc00] */
            ii(0x1016_be18, 6); mov(ebp, memd_a32[ds, 0x101b_de60]);    /* mov ebp, [0x101bde60] */
            ii(0x1016_be1e, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1016_be21:
            ii(0x1016_be21, 6); mov(memd_a32[ds, 0x101b_de60], ebp);    /* mov [0x101bde60], ebp */
            ii(0x1016_be27, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_be2a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_be2b, 1); popd(edi);                              /* pop edi */
            ii(0x1016_be2c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_be2d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_be2e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_be2f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_be30, 1); retd(); return;                         /* ret */
        }
    }
}
